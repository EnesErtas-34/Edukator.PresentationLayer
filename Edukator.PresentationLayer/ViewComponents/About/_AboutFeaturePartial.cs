using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutFeaturePartial:ViewComponent
    {
        private readonly IAboutFeatureService _aboutFeatureService;

        public _AboutFeaturePartial(IAboutFeatureService aboutFeatureService)
        {
            _aboutFeatureService = aboutFeatureService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_aboutFeatureService.TGetList();
            return View(values);
        }
    }
}
