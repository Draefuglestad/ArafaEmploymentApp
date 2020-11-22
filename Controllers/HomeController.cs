using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArafaEmploymentApp.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
            var session = HttpContext.Session.GetString("Applicant");
            if (session != null)
            {
                ViewData.Model = JsonConvert.DeserializeObject<Applicant>(session);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ApplicantInformation(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Applicant", JsonConvert.SerializeObject(applicant));
                return RedirectToAction("EmploymentHistory");
            }
            return View();
        }

        public IActionResult EmploymentHistory()
        {
            var session = HttpContext.Session.GetString("EmploymentHistory");
            if (session != null)
            {
                ViewData.Model = JsonConvert.DeserializeObject<EmploymentHistory>(session);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EmploymentHistory(EmploymentHistory employmentHistory)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("EmploymentHistory", JsonConvert.SerializeObject(employmentHistory));
                return RedirectToAction("Availability");
            }
            return View();
        }

        public IActionResult Availability()
        {
            var session = HttpContext.Session.GetString("Availability");
            if (session != null)
            {
                ViewData.Model = JsonConvert.DeserializeObject<Availability>(session);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Availability(Availability availability)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Availability", JsonConvert.SerializeObject(availability));
                return RedirectToAction("Education");
            }
            return View();
        }




        public IActionResult Education()
        {
            var session = HttpContext.Session.GetString("Education");
            if (session != null)
            {
                ViewData.Model = JsonConvert.DeserializeObject<Education>(session);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Education(Education education)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Education", JsonConvert.SerializeObject(education));
                return RedirectToAction("Background");
            }
            return View();
        }
       

       

        public IActionResult Background()
        {
            var session = HttpContext.Session.GetString("Background");
            if (session != null)
            {
                ViewData.Model = JsonConvert.DeserializeObject<Background>(session);
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Background(Background background)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Background", JsonConvert.SerializeObject(background));
                return RedirectToAction("References");
            }
            return View();
        }

        public IActionResult References()
        {
            var session = HttpContext.Session.GetString("References");
            if (session != null)
            {
                ViewData.Model = JsonConvert.DeserializeObject<References>(session);
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult References(References references)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("References", JsonConvert.SerializeObject(references));
                return RedirectToAction("Waiver");
            }
            return View();
        }


        public IActionResult Waiver()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Waiver(Waiver waiver)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Submission");
            }
            return View();
        }

        public IActionResult Submission()
        {
            return View();
        }

    }
}
