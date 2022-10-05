using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTea.DAL.Model
{
    public class DBContextApplication : DbContext
    {
        public DBContextApplication(DbContextOptions<DBContextApplication> options) : base(options)
        {

        }
        public DbSet<Facility> Facilities { set; get; }

        public DbSet<Doctor> Doctors { set; get; }

        public DbSet<Location> locations { set; get; }

        public DbSet<AssociatedProvider> associatedProviders { set; get; }

        public DbSet<AssociatedProviderDoctor> associatedProviderDoctors{set;get;}
    }
}
