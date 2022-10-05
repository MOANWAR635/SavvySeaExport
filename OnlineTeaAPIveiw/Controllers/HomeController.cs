using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnlineTea.DAL.Model;
using OnlineTeaAPIveiw.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OnlineTeaAPIveiw.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContextDB _logger;

        public HomeController(ApplicationContextDB logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<AssociatedProviderDoctor> AssociatedProviderDoctor =
                new List<AssociatedProviderDoctor>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44387/");
            HttpResponseMessage response = await client.GetAsync
               ("api/controller/GetList");

            if(response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;

                AssociatedProviderDoctor = JsonConvert.DeserializeObject<List<AssociatedProviderDoctor>>(result);
            }

            return View(AssociatedProviderDoctor);
        }

        ////hearing use get Details from databases 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        //[HttpGet]
        //public async Task<IActionResult> Details1(int id)
        //{
        //    AssociatedProviderDoctor AssociatedProviderDoctor =
        //        new AssociatedProviderDoctor();
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://localhost:44387/");
        //    HttpResponseMessage response = await client.GetAsync
        //       ($"api/controller/GetSigleData/{id}");

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var result = response.Content.ReadAsStringAsync().Result;

        //        AssociatedProviderDoctor = JsonConvert.DeserializeObject<AssociatedProviderDoctor>(result);
        //    }

        //    return View(AssociatedProviderDoctor);
        //}
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            AssociatedProviderDoctor AssociatedProviderDoctor =
                new AssociatedProviderDoctor();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44387/");
            HttpResponseMessage response = await client.GetAsync
               ($"api/controller/GetSigleData/{id}");

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;

                AssociatedProviderDoctor = JsonConvert.DeserializeObject<AssociatedProviderDoctor>(result);
            }

            return View(AssociatedProviderDoctor);
        }






        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create( AssociatedProviderDoctor associatedProvider)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44387/");
            var  response = await client.PostAsJsonAsync <AssociatedProviderDoctor>
               ("api/controller/AddAssociated",associatedProvider);

            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }



            return View();
        }


        public async Task<IActionResult> Delete( int id)
        {
        
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44387/");
            HttpResponseMessage response = await client.DeleteAsync
               ($"api/controller/Delete{id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
