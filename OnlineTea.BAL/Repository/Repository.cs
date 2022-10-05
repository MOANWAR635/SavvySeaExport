using OnlineTea.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.BAL.Repository
{
    public class Repository: IRepository
    {
        private readonly DBContextApplication _DbContext;

        public Repository(DBContextApplication _DbContext1 )
        {
            _DbContext = _DbContext1;
        }

        public AssociatedProviderDoctor AddAssociated(AssociatedProviderDoctor associatedProvider)
        {
           
            if (associatedProvider.Id ==0)
            {
                AssociatedProviderDoctor doctor = new AssociatedProviderDoctor();

                doctor.FacilityId =  associatedProvider.FacilityId;
                doctor .DoctorId =   associatedProvider.DoctorId;
                doctor. LocationId = associatedProvider.LocationId;
               

                if (doctor != null)
                {
                    _DbContext.associatedProviderDoctors.AddAsync(doctor);

                    _DbContext.SaveChangesAsync();
                    // _DbContext.associatedProviders.a
                    return doctor;
                }

            }

            else 
            {
                var update = _DbContext.associatedProviderDoctors.Where(x => x.Id == associatedProvider.Id).FirstOrDefault();
                
                update.FacilityId = associatedProvider.FacilityId;
                update.DoctorId =   associatedProvider.DoctorId;
                update.LocationId = associatedProvider.LocationId;
                _DbContext.associatedProviderDoctors.UpdateRange(update);
                _DbContext.SaveChangesAsync();
                return update;
            }

            return null;

        }

        public AssociatedProviderDoctor DeleteAssociated(int id)
        {
            var DeleteData = _DbContext.associatedProviderDoctors.Where(x => x.Id == id).FirstOrDefault();
            _DbContext.associatedProviderDoctors.RemoveRange(DeleteData);

            _DbContext.SaveChangesAsync();

            return DeleteData;
        }

        public List<AssociatedProviderDoctor> ListofDoctor()
        {
            var listdata = _DbContext.associatedProviderDoctors.ToList();

            return listdata;
        }


        public AssociatedProviderDoctor  getSingleData(int id)
        {
            var getSingleData = _DbContext.associatedProviderDoctors.Where(x => x.Id == id).FirstOrDefault();

            return getSingleData;

        }
    }
}
