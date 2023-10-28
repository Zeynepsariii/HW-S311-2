using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class LeftNavigationViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View("LeftNavigation");
    }

}