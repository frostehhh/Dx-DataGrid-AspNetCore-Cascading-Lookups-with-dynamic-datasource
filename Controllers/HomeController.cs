using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using T880809.Models;

namespace T880809.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DataGridViewModel model = new DataGridViewModel
            {
                CitiesUS = SampleData.CitiesUS,
                CitiesRussia = SampleData.CitiesRussia,
                CitiesUnitedKingdom = SampleData.CitiesUnitedKingdom
            };

            return View(model);
        }

        [HttpGet]
        public object GetCountries(DataSourceLoadOptions loadOptions)
        {
            
            return DataSourceLoader.Load(SampleData.Countries, loadOptions);
        }

    }
}
