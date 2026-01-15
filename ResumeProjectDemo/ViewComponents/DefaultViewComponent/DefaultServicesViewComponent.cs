using Microsoft.AspNetCore.Mvc;
using NuGet.Configuration;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultServicesViewComponent : ViewComponent
    {
        private readonly ResumeContext _resumeContext;

        public DefaultServicesViewComponent(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _resumeContext.Services.ToList();
            return View(values);
        }
    }
}
