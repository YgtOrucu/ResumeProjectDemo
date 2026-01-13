using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultTestimonialViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
