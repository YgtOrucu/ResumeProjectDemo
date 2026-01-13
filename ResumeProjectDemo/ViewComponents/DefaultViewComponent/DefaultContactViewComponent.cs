using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultContactViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
