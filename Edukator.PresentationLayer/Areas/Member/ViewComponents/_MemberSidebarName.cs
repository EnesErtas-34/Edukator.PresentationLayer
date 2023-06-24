using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Areas.Member.ViewComponents
{
    public class _MemberSidebarName:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _MemberSidebarName(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.name = await _userManager.FindByNameAsync(User.Identity.Name);
           
            return View();
        }
    }
}
