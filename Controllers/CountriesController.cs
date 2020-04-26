using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using T880809.Models;

namespace T880809.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.Countries, loadOptions);
        }
    }
}