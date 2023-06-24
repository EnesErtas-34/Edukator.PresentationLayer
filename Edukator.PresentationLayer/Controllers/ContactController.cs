using Edukator.BusinessLayer.Abstract;
using Edukator.BusinessLayer.Concrete;
using Edukator.DataAccessLayer.EntityFramework;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactInfoService _contactInfoService;
        private readonly IContactService _contactService;

        

        public ContactController(IContactInfoService contactInfoService, IContactService contactService)
        {
            _contactInfoService = contactInfoService;
            _contactService = contactService;
        }

      

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Contact p)
        {
            _contactService.TInsert(p);
            return RedirectToAction("Index");
        }
    }
}
