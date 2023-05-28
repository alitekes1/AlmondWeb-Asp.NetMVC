using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class mylist
    {
        [Key] 
        public int listID { get; set; } 
        
        [StringLength(50)]
        public string listName{ get; set; }

        public ICollection<mylist> Mylists { get; set;}
    }
}
