using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Courses
{
    public class _CoursesFeaturePartial:ViewComponent
    {
        private readonly ICoursesFeatureService _coursesFeatureService;

        public _CoursesFeaturePartial(ICoursesFeatureService coursesFeatureService)
        {
            _coursesFeatureService = coursesFeatureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _coursesFeatureService.TGetList();
            return View(values);
        }
    }
}
