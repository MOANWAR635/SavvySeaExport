using OnlineTea.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.BAL.MapperData
{
  public interface IPropertyMapper
    {
        public bool AssociatedDoctorDataModel (int Facilityid, int DoctorId, int LocationId);
       
    }
}
