using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultContactViewComponent: ViewComponent
    {
        private readonly ResumeContext _resumeContext;

        public DefaultContactViewComponent(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _resumeContext.Contacts.FirstOrDefault();
            return View(values);
        }
    }
}
