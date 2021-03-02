using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal ColorDal)
        {
            _colorDal = ColorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        List<Color> IColorService.GetById(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
