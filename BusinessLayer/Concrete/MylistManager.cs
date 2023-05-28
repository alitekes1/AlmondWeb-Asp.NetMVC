using DataAccsessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MylistManager
    {
        GenericRepository<mylist> repo=new GenericRepository<mylist> ();
        public List<mylist> GetAllBL()
        {
            return repo.List();//listeleme işlemleri
        }
    }
}
