using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemo.Context;
using ResumeProjectDemo.Entities;

namespace ResumeProjectDemo.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly ResumeContext _resumeContext;

        public ExperienceController(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IActionResult ExperienceList()
        {
            var values = _resumeContext.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience e)
        {
            _resumeContext.Experiences.Add(e);
            _resumeContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = _resumeContext.Experiences.Find(id);

            _resumeContext.Experiences.Remove(values);
            _resumeContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var getvalues = _resumeContext.Experiences.Find(id);
            return View("EditExperience", getvalues);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience e)
        {
            _resumeContext.Experiences.Update(e);
            _resumeContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
