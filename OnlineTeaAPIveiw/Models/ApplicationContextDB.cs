using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTeaAPIveiw.Models
{
    public class ApplicationContextDB :DbContext
    {

        public ApplicationContextDB(DbContextOptions<ApplicationContextDB> options):base(options)
        {

        }
        public DbSet<Student> students { set; get; }
    }
}
