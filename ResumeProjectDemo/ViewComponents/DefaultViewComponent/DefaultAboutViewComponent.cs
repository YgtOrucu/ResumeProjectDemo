using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Models.ViewModelForAboutArea;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultAboutViewComponent : ViewComponent
    {
        private readonly ResumeContext _resumeContext;
        public DefaultAboutViewComponent(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }
        public IViewComponentResult Invoke()
        {

            var modelsForAbout = new ModelsForAboutArea
            {
                Abouts = _resumeContext.Abouts.FirstOrDefault(),
                Experiences = _resumeContext.Experiences.Take(2).ToList(),
                Educations = _resumeContext.Educations.ToList()  
            };


            return View(modelsForAbout);
        }
    }
}
