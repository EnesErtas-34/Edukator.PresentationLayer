using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Contact
{
    public class _ContactMapPartial:ViewComponent
    {
        private readonly IMapService _mapService;

        public _ContactMapPartial(IMapService mapService)
        {
            _mapService = mapService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _mapService.TGetList();
            return View(values);
        }
    }
}
