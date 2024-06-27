using E_Learning_Project_final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_Project_final.Controllers
{
    public class AdminController : Controller
    {
        //[Authorize(Policy = "AdminOnly")]
        public ViewResult Admin()
        {

            return View();

        }
        public IActionResult CourseSub()
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            IServices<Course> rep = new GenericRepository<Course>(conn);
            List<Course> products = rep.GetAll().ToList();
            return View(products);


        }
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
        public IActionResult DeleteStat(int id)
        {
            List<Course> c = new List<Course>();

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            IServices<Course> rep = new GenericRepository<Course>(conn);
            rep.Delete(id);
            return RedirectToAction("CourseSub", "Admin");


        }

        public ViewResult faqs()
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            IServices<FAQs> rep = new GenericRepository<FAQs>(conn);
            List<FAQs> products = rep.GetAll().ToList();

            return View(products);
        }
        public ViewResult Submit()
		{
			ServicesRepository d = new ServicesRepository();
			List<Feed> l = d.GetFeeds();
			return View(l);
		}
		public IActionResult DeleteName(string name)
		{
			List<Feed> c = new List<Feed>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
			IServices<Feed> rep = new GenericRepository<Feed>(conn);
            rep.DeleteByString(name);
			return RedirectToAction("Submit", "Admin");


		}
	}
}
