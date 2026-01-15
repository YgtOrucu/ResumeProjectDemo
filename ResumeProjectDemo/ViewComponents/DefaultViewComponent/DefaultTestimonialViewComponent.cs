using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultTestimonialViewComponent : ViewComponent
    {
        private readonly ResumeContext _resumeContext;

        public DefaultTestimonialViewComponent(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _resumeContext.Testimonials.ToList();
            return View(values);
        }
    }
}
