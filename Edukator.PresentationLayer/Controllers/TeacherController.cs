using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public IActionResult Index()
        {
            var values = _teacherService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            _teacherService.TInsert(teacher);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTeacher(int id)
        {
            var values = _teacherService.TGetByID(id);
            _teacherService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTeacher(int id)
        {
            var values=_teacherService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTeacher(Teacher teacher)
        {
            _teacherService.TUpdate(teacher);
            return RedirectToAction("Index");
        }
    }
}
