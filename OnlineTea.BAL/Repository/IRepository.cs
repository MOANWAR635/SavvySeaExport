using OnlineTea.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.BAL.Repository
{
    public interface IRepository
    {
        public AssociatedProviderDoctor AddAssociated(AssociatedProviderDoctor associatedProvider);

        public AssociatedProviderDoctor DeleteAssociated(int id);

        public  List<AssociatedProviderDoctor> ListofDoctor();

        public  AssociatedProviderDoctor getSingleData(int id);


    }
}
