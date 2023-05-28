using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IRepositoryDal<Tablo>
    {
        List<Tablo> List();

        void  Insert(Tablo tablo);  
        void Update(Tablo tablo);
        void Delete(Tablo tablo);
        
        List<Tablo> sartliList(Expression<Func<Tablo, bool>> filter);
    }
}
