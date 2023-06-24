using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Contact
{
    public class _ContactInfoPartial:ViewComponent
    {
        private readonly IContactInfoService _contactInfoService;

        public _ContactInfoPartial(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactInfoService.TGetList();
            return View(values);
        }
    }
}
