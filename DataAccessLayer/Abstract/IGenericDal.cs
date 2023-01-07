﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
 public   interface IGenericDal<T> where T:class
    {
        void İnsert(T t);
        void Delete(T t);
        void Up(T t);
        List<T> GetList();

        T GEtByID(int id);

    }
}
