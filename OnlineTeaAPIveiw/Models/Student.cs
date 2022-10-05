using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTeaAPIveiw.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Address{ get; set; }
        public string  pincode { get; set; }
    }
}
