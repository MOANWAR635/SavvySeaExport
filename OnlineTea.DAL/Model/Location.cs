using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.DAL.Model
{
   public  class Location
    {
        [Key]
        public int Id { get; set; }
        public Doctor doctor { set; get; }
        public string Fname { get; set; }
    }
}
