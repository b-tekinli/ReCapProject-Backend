using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetById(int colorId);
    }
}
