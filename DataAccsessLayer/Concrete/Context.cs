using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Data> Datas{ get; set; }
        public DbSet<general> Generals{ get; set; }
        public DbSet<mylist> Mylists{ get; set; }
        public DbSet<User> Users{ get; set; }

    }
}
