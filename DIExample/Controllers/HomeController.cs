using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly CitiesService _citiesService;

        public HomeController(){
            _citiesService = new CitiesService();
        }

        [Route("/")]
        public IActionResult Index(){
            List<string> cities = _citiesService.GetCities();
            return View(cities);
        }
    }
}