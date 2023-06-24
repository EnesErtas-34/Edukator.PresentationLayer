using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _ReferencePartial:ViewComponent
    {
        private readonly IReferenceService _referenceService;

        public _ReferencePartial(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _referenceService.TGetList();
            return View(values);
        }
    }
}
