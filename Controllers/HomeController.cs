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

        public IActionResult Education()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Education(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Background");
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ApplicantInformation(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("EmploymentHistory");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EmploymentHistory(EmploymentHistory employmentHistory)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Education");
            }
            return View();
        }

        public IActionResult Background()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Background(Background background)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("References");
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
        public IActionResult References(References references)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Submission");
            }
            return View();
        }
    }
}
