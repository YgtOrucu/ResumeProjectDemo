using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultCategoriesViewComponent : ViewComponent
    {
        private readonly ResumeContext _resumeContext;

        public DefaultCategoriesViewComponent(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _resumeContext.Categories.ToList();
            return View(values);
        }
    }
}
