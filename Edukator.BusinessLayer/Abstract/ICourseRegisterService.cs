﻿using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Abstract
{
    public interface ICourseRegisterService:IGenericService<CourseRegister>
    {
        List<CourseRegister> TCourseRegistersListWithCoursesAndUser();
        List<CourseRegister> TCourseRegisterListWithCourseByUser(int id);
    }
}
