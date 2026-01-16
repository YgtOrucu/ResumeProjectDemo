using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultSkillViewComponent : ViewComponent
    {
        private readonly ResumeContext _resumeContext;
        public DefaultSkillViewComponent(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _resumeContext.Skills.ToList();
            return View(values);
        }
    }
}
