using Microsoft.AspNetCore.Mvc;
using OnlineTea.BAL.MapperData;
using OnlineTea.BAL.Repository;
using OnlineTea.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTea.Controllers
{
    [Route("api/controller")]
    public class HomeController : Controller
    {

        

        private readonly IRepository _DB;
       // private readonly IPropertyMapper mapper;
        public HomeController(IRepository _DBContext)
        {
            _DB = _DBContext;
        }

        [HttpPost]
        [Route("AddAssociated")]
        public  IActionResult AddAssociatedDoctor(AssociatedProviderDoctor associatedProvider)
        {

       


            var addAssociated =  _DB.AddAssociated(associatedProvider);

            return Ok(addAssociated);
        }


        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteData(int id)
        {
            var deletedata = _DB.DeleteAssociated(id);
            return Ok(deletedata);
        }


        [HttpGet]
        [Route("GetList")]
        public IActionResult getDatafromdatabases()
        {
            var listdata = _DB.ListofDoctor();
            return Ok(listdata);
        }
        [HttpGet]
        [Route("GetSigleData")]
        public IActionResult getSingleDatafromdatabases(int id)
        {
            var listdata = _DB.getSingleData(id);
            return Ok(listdata);
        }

    }
}
