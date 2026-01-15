using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultFeatureViewComponent : ViewComponent
    {
        private readonly ResumeContext _resumeContext;
        public DefaultFeatureViewComponent(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _resumeContext.Abouts.Select(x => new About
            {
                NameSurname = x.NameSurname,
                Title = x.Title,
                ImageUrl = x.ImageUrl
            }).FirstOrDefault();

            return View(values);
        }
    }
}
