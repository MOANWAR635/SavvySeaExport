using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.DAL.Model
{
   public  class Facility
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Doctor> doctors { set; get; }
        public string Fname { get; set; }

    }
}
