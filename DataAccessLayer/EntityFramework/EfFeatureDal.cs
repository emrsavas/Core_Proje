﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositoy;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeatureDal :GenericRepositoy<Feature> ,IFeatureDal
    {
    }
}
