using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            List<JobPostings> allJobPostings = JobPostings.GetAll();
            return View(allJobPostings);
        }

        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/jobs")]
        public ActionResult CreateJobPost(string title, string description, string contactInfo)
        {
            JobPostings job = new JobPostings(title, description, contactInfo);
            return RedirectToAction("Index");
        }


    }
}
