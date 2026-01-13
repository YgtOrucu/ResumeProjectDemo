using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemo.ViewComponents.DefaultViewComponent
{
    public class DefaultPortfolioViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
