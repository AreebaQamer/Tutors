using System.Security.Cryptography.Xml;
using E_Learning_Project_final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Services.Controllers;

namespace E_Learning_Project_final.Controllers
{
    public class ServicesCategoryController : Controller
    {
        private readonly ILogger<ServicesCategoryController> _logger;
        private readonly IWebHostEnvironment _env;

        public ServicesCategoryController(ILogger<ServicesCategoryController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }
    public IActionResult Category()
        {

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            IServices<Category> rep = new GenericRepository<Category>(conn);
            List<Category> products = rep.GetAll().ToList();
            return View(products);
        }
        public IActionResult Course()
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            IServices<Course> rep = new GenericRepository<Course>(conn);
            List<Course> products = rep.GetAll().ToList();
            return View(products);


        }
        // get course 1
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
        
        
        //adding  Course
        public ViewResult AddCourse()
        {
            return View();
        }
        //update Course
        public ViewResult UpdateCourse()
        {
            return View();
        }
        //delete Course

        public ViewResult Delete()
        {
            return View();
        }
        //method to call add 

        [Authorize(Policy = "AdminOnly")]

        [HttpPost]
        public IActionResult Add1(int id, string name, string description, string price, IFormFile videos ,string catname)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string fileName = Path.GetFileName(videos.FileName);
            string fileExtension = Path.GetExtension(videos.FileName);
            Course c = new Course
            {
                CourseId=id,
                Name = name,
                Description = description,
                Price = price,
                Videos = fileName,
                CateName=catname
            };
            IServices<Course> repository = new GenericRepository<Course>(conn);
            repository.Add(c);
            string wwwrootPath = _env.WebRootPath;
            string path = Path.Combine(wwwrootPath, "UploadFiles");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = Path.Combine(path, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                videos.CopyTo(fileStream);
            }
            return RedirectToAction("CourseSub", "Admin");

        }
        
      //method to update Course
        [HttpPost]
        public IActionResult Update1(int id, string name, string description, string price,string cat ,string catname,  IFormFile videos)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string fileName = Path.GetFileName(videos.FileName);
            string fileExtension = Path.GetExtension(videos.FileName);
            Course c = new Course
            {
                CourseId = id,
                Name = name,
                Description = description,
                Price = price,
                Videos = fileName,
                CateName = catname
            };
            IServices<Course> repository = new GenericRepository<Course>(conn);
            repository.Update(c);
            string wwwrootPath = _env.WebRootPath;
            string path = Path.Combine(wwwrootPath, "UploadFiles");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = Path.Combine(path, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                videos.CopyTo(fileStream);
            }
            
            return RedirectToAction("CourseSub", "Admin");

        }

        //method to delelte Course
     
      
    }
}

