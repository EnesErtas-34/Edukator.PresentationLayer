using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ISubscribeService _subscribeService;

        public DefaultController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddSubscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return RedirectToAction("Index");
        }
    }
}
