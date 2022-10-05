using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.DAL.Model
{
    public class AssociatedProviderDoctor
    {
        [Key]
        public int Id { get; set; }
       
        public int FacilityId { get; set; }

        public int DoctorId { get; set; }

        public int LocationId { get; set; }
        



    }
}
