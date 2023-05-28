using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Data
    {
        [Key]
        public int dataID { get; set; }
        
        [StringLength(200)]
        public string question { get; set; }
        [StringLength(200)]
        public string answer { get; set; }
        public int puan{ get; set; }
        public DateTime saveDate { get; set; }
        public bool datastatus { get; set; }


        public ICollection<general> generals { get; set; }

        public int userID { get; set; }
        public virtual User User{ get; set; }
    }
}
