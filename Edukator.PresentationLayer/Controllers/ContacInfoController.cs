using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class ContacInfoController : Controller
    {
        private readonly IContactInfoService _contactInfoService;

        public ContacInfoController(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public IActionResult Index()
        {
            var values = _contactInfoService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddContactInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContactInfo(ContactInfo contactInfo)
        {
            _contactInfoService.TInsert(contactInfo);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteContactInfo(int id)
        {
            var values = _contactInfoService.TGetByID(id);
            _contactInfoService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateContactInfo(int id)
        {
            var values = _contactInfoService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateContactInfo(ContactInfo contactInfo)
        {
            _contactInfoService.TUpdate(contactInfo);
            return RedirectToAction("Index");
        }
    }
}
