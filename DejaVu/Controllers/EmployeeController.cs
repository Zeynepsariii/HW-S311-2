
﻿using Microsoft.AspNetCore.Mvc;
using DejaVu.Models; // Adjust the namespace if necessary
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class EmployeeController : Controller
{
    private readonly EmployeeContext _context;

    public EmployeeController(EmployeeContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Employees.ToListAsync());
    }

    public async Task<IActionResult> Details(int id)
    {
        var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        if (employee == null)
        {
            return NotFound();
        }
        return View(employee);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var employee = await _context.Employees.FindAsync(id);
        if (employee == null)
        {
            return NotFound();
        }
        return View(employee);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Employee employee)
    {
        if (id != employee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(employee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(employee.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(employee);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Employee employee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(employee);
    }

    private bool EmployeeExists(int id)
    {
        return _context.Employees.Any(e => e.Id == id);
    }
}
