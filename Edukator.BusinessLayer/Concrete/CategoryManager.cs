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
    public class CategoryManager : ICategoryService//t değerleri genericservice içinde *Aynı katmanda imzasından miras almalı
    {
        private readonly ICategoryDal _categoryDal;//IcategoryDal almamızın sebebi crud işlemleri burada.categorydal üzerinden de onlara erişim sağlıcaz

        public CategoryManager(ICategoryDal categoryDal)//yapıcı method
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t); 
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            
            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
