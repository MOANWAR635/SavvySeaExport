using Microsoft.AspNetCore.Mvc;
using OnlineTeaAPIveiw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTeaAPIveiw.Controllers
{
    public class StudentController : Controller
    {
        
        private ApplicationContextDB dB;

        public StudentController(ApplicationContextDB applicationContext)
        {
            dB = applicationContext;
        }
        public IActionResult Student()
        {
            try
            {
                var student = dB.students.ToList();


                return View(student);
            }
            catch (Exception)
            {

                throw;
            }

           
        }
        [HttpGet]
        public  IActionResult Delete(int id)
        {
            try
            {
                var studentid =  dB.students.Find(id);
                dB.Remove(studentid);
                dB.SaveChanges();

                return View(studentid);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public IActionResult AddStudent(Student student)
        {
            
            try
            {
                if(student!=null)
                {

                    var adddata = dB.Add(student);
                    dB.SaveChanges();
                    return View(adddata);
                }
                return View(null);
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }


    }
}
