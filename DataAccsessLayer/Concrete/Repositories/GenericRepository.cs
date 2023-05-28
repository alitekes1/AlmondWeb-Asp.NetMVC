using DataAccsessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepositoryDal<T> where T : class
    {
        DbSet<T> _object;
        Context c = new Context();


        public GenericRepository()
        {
            _object = c.Set<T>();//context e bağlı olarak gönderilen tablo onject e atanıyor.
        }

        public void Delete(T deger)
        {
            _object.Remove(deger);
            c.SaveChanges();
        }

        public void Insert(T deger)
        {
            _object.Add(deger);
            c.SaveChanges();

        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> sartliList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();  
        }

        public void Update(T tablo)
        {
            c.SaveChanges();
        }
    }

}
