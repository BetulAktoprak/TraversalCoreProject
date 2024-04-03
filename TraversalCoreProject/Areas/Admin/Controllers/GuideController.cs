using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DocumentFormat.OpenXml.Spreadsheet;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(int id, bool status)
        {
            var item = _guideService.TGetByID(id);
            if (item != null)
            {
                item.Status = status;
                _guideService.TUpdate(item); 
            }
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                return Redirect("/Admin/Guide/Index/");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return Redirect("/Admin/Guide/Index/");
        }

        public IActionResult DeleteGuide(int id)
        {
            var values = _guideService.TGetByID(id);
            _guideService.TDelete(values);
            return Redirect("/Admin/Guide/Index/");
        }
    }
}
