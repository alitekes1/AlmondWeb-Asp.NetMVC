using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        
        [StringLength(50)]
        public string username { get; set; }
        [StringLength(50)]
        public string surname { get; set; }
        [StringLength(50)]
        public string useremail { get; set; }
        [StringLength(50)]
        public string subject { get; set; }
        [StringLength(500)]
        public string message { get; set; }
    }
}
