using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArafaEmploymentApp.Models;

namespace ArafaEmploymentApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ApplicantInformation()
        {
            return View();
        }

        public IActionResult EmploymentHistory()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ApplicantInformation(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("EmploymentHistory");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EmploymentHistory(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("EmploymentHistory");
            }
            return View();
        }

        public IActionResult Background()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Background(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("Background");
            }
            return View();
        }

        public IActionResult References()
        {
            return View();
        }

        public IActionResult Submission()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult References(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("References");
            }
            return View();
        }
    }
}
