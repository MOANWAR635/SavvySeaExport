using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.DAL.Model
{
   public  class AssociatedProvider
    {
        [Key]
        public int Id { get; set; }
        public Facility facilities { set; get; }
        public Doctor doctors { set; get; }
        public Location locations { set; get; }
        public string Aname { get; set; }
    }
}
