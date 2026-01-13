using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultServicesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
