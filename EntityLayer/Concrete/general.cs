using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class general
    {
        [Key]
        public int generalID { get; set; }

        public int dataID { get; set; }
        public virtual Data Data { get; set; }

        public int listID { get; set; }
        public virtual mylist Mylist { get; set; }

        public int? userID { get; set; }
        public virtual User User  { get; set; }

    }
}
