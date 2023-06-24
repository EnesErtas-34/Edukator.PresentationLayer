using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult MemberSideBarPartial()
        {
            return PartialView();
        }
    }
}
