using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using E_Learning_Project_final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Home.Controllers
{

    public class HomeController : Controller
    {
        [Authorize]
        public ViewResult Index()
        {

            
            ViewBag.Message = "With our Classes";
            ViewData["Caption"] = "Teaching in the Internet age means we must teach tomorrow's skills today";
            return View();
        }
        public ViewResult About()
        {
            TempData["about"] = "  Tutors is your go-to destination for exceptional online learning services We are a team of passionate experts, dedicated to crafting learning modules that empower businesses and individuals to succeed in the future world.\r\n                    From languages  to development, digital marketing and cloud hosting, we have the expertise and experience to make a meaningful impact on your online success. Let's collaborate and bring your successful version to life.";


            return View();
        }
        public ViewResult DashBoard()
        {
            return View();

        }

        //[Authorize(Policy = "AdminOnly")]
      
        public IActionResult Course1()
        {
            ServicesRepository productsRepository = new ServicesRepository();
            List<Course> products = productsRepository.GetCourse1();
            return View(products);
        }
        //get course 2
        public IActionResult Course2()
        {
            ServicesRepository productsRepository = new ServicesRepository();
            List<Course> products = productsRepository.GetCourse2();
            return View(products);
        }
        //get course 3

        public IActionResult Course3()
        {
            ServicesRepository productsRepository = new ServicesRepository();
            List<Course> products = productsRepository.GetCourse3();
            return View(products);
        }
        //get course 4
        public IActionResult Course4()
        {
            ServicesRepository productsRepository = new ServicesRepository();
            List<Course> products = productsRepository.GetCourse4();
            return View(products);
        }
        //get course 5
        public IActionResult Course5()
        {
            ServicesRepository productsRepository = new ServicesRepository();
            List<Course> products = productsRepository.GetCourse5();
            return View(products);
        }
        //get course 6
        public IActionResult Course6()
        {
            ServicesRepository productsRepository = new ServicesRepository();
            List<Course> products = productsRepository.GetCourse6();
            return View(products);
        }

    }

}
