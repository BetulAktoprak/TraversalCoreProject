using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminDashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
