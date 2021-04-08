using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dataprossing;

namespace DataprossingWeb.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {

            string v = System.IO.Path.GetDirectoryName(".");
            var filename = @"C:\Users\fuanh\Documents\NKUST-109-2\DataprossingWeb\data.json";
            List <PopulationAgeGroupInBaishaPenghu> data = Repository.readData(filename);
            return View(data);
        }
    }
}
