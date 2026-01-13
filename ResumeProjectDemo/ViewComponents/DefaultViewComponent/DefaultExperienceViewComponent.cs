using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultExperienceViewComponent : ViewComponent
    {
        private readonly ResumeContext _resumeContext;

        public DefaultExperienceViewComponent(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _resumeContext.Experiences.ToList();
            return View(values);
        }
    }
}
