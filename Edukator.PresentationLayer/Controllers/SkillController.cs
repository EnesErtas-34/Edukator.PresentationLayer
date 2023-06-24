using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var values = _skillService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _skillService.TInsert(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = _skillService.TGetByID(id);
            _skillService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = _skillService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _skillService.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
