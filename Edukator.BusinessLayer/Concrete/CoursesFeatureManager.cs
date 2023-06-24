using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class CoursesFeatureManager : ICoursesFeatureService
    {
        private readonly ICoursesFeatureDal _coursesFeatureDal;

        public CoursesFeatureManager(ICoursesFeatureDal coursesFeatureDal)
        {
            _coursesFeatureDal = coursesFeatureDal;
        }

        public void TDelete(CoursesFeature t)
        {
            _coursesFeatureDal.Delete(t);
        }

        public CoursesFeature TGetByID(int id)
        {
            return _coursesFeatureDal.GetByID(id);
        }

        public List<CoursesFeature> TGetList()
        {
            return _coursesFeatureDal.GetList();
        }

        public void TInsert(CoursesFeature t)
        {
            _coursesFeatureDal.Insert(t);
        }

        public void TUpdate(CoursesFeature t)
        {
            _coursesFeatureDal.Update(t);
        }
    }
}
