using OnlineTea.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.BAL.MapperData
{
    public class PropertyMapper : IPropertyMapper
    {
        private  readonly DBContextApplication _PbContext;

        public PropertyMapper(DBContextApplication dBContext)
        {
            _PbContext = dBContext;
        }
        public bool AssociatedDoctorDataModel(int Facilityid, int DoctorId, int LocationId)
        {
            try
            {
              if(Facilityid != null)
               {
                AssociatedDoctorDataModel associatedDoctorDataModel = new AssociatedDoctorDataModel();

                    associatedDoctorDataModel.FacilityId = associatedDoctorDataModel.FacilityId;
                    associatedDoctorDataModel.DoctorId = associatedDoctorDataModel.DoctorId;
                    associatedDoctorDataModel.LocationId = associatedDoctorDataModel.LocationId;

                    return true;

                }
                else
                //AssociatedDoctorDataModel associatedDoctorDataModel = new AssociatedDoctorDataModel();

                //associatedDoctorDataModel.FacilityId = associatedDoctorDataModel.FacilityId;
                //associatedDoctorDataModel.DoctorId = associatedDoctorDataModel.DoctorId;
                //associatedDoctorDataModel.LocationId = associatedDoctorDataModel.LocationId;

                return false;

            }

            catch (Exception)
            {

                throw;
            }
           

            
        
        }
    }
}
