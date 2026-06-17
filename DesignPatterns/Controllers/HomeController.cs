using DesignPatterns.Models;
using DesignPatterns.Repositories;
using DesignPatterns.FactoryMethods;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IVehicleRepository _vehicleRepository;
        private readonly IVehicleFactoryCatalog _vehicleFactoryCatalog;

        public HomeController(
            IVehicleRepository vehicleRepository,
            IVehicleFactoryCatalog vehicleFactoryCatalog,
            ILogger<HomeController> logger)
        {
            _vehicleRepository = vehicleRepository;
            _vehicleFactoryCatalog = vehicleFactoryCatalog;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.Vehicles = _vehicleRepository.GetVehicles();
            model.AvailableModels = _vehicleFactoryCatalog.GetAvailableModels();
            string error = Request.Query.ContainsKey("error") ? Request.Query["error"].ToString() : null;
            ViewBag.ErrorMessage = error;

            return View(model);
        }

        [HttpGet]
        public IActionResult AddMustang()
        {
            return AddVehicle("Mustang");
        }

        [HttpGet]
        public IActionResult AddExplorer()
        {
            return AddVehicle("Explorer");
        }

        [HttpGet]
        public IActionResult AddEscape()
        {
            return AddVehicle("Escape");
        }

        [HttpGet]
        public IActionResult AddVehicle(string model)
        {
            // The catalog chooses the concrete factory, keeping this controller closed to new vehicle models.
            _vehicleRepository.AddVehicle(_vehicleFactoryCatalog.CreateVehicle(model));
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult StartEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StartEngine();
                return Redirect("/");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
          
        }

        [HttpGet]
        public IActionResult AddGas(string id)
        {

            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.AddGas();
                return Redirect("/");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult StopEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StopEngine();
                return Redirect("/");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
           
           
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
