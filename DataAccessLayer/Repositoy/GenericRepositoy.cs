using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositoy
{
    public class GenericRepositoy<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();

        }
        //VİDEO 15
        public T GEtByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public void Up(T t)
        {
            throw new NotImplementedException();
        }

        public void İnsert(T t)
        {
            throw new NotImplementedException();
        }
    }
}
