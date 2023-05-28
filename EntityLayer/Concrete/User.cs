using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class User
    {
        [Key]   
        public int userID { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string surname { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string password { get; set; }


        public ICollection<Data> Datas { get; set; }

        public ICollection<general> Generals { get; set; }
    }
}
