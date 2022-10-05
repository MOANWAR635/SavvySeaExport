using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.DAL.Model
{
   public  class Doctor
    {
        [Key]
        public int Id { get; set;}

        public Facility facility { set; get; }
        public ICollection<Location> locations { set; get; }
        public string Dname { get; set; }

        public string Address { get; set; }

    }
    

}
