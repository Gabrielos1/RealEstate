﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using RealEstate.Data;
using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IConfiguration _configuration;
        //public MongoDatabase Database;

        public RealEstateContext Context = new RealEstateContext();

        //public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        //{
        //    _logger = logger;
        //    _configuration = configuration;

        //    var client = new MongoClient(configuration["ConnectionStrings:RealEstateConnectionString"]);
        //    var server = client.GetServer();
        //    Database = server.GetDatabase(configuration["RealEstateDatabaseName"]);
        //}

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Context.Database.GetStats();

            return Json(Context.Database.Server.BuildInfo);
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

        #region Generated HomeController
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        #endregion
    }
}
