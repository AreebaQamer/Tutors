using System.Composition;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using E_Learning_Project_final.Data.Migrations;
using E_Learning_Project_final.Models;
using Feedback.Controllers; 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;
using Services.Controllers;
namespace Feedback.Controllers
{
    public class FeedbackController : Controller
    {
        public ViewResult Submit()
        {
            ServicesRepository d = new ServicesRepository();
            List<Feed> l = d.GetFeeds();
            return View(l);
        }
        public ViewResult Addfeedback()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string name, string email, string satisfy, string suggestion)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            Feed c = new Feed
            {

                Name = name,
                Email = email,
                Satisfaction = satisfy,
                Suggestions = suggestion
            };
            IServices<Feed> repository = new GenericRepository<Feed>(conn);
            repository.Add(c);

            return RedirectToAction("Submit", "Feedback");
        }
        public IActionResult Update(string name, string email, string satisfy, string suggestion)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            Feed c = new Feed
            {

                Name = name,
                Email = email,
                Satisfaction = satisfy,
                Suggestions = suggestion
            };
            IServices<Feed> repository = new GenericRepository<Feed>(conn);
            repository.Update(c);

            return RedirectToAction("Submit", "Feedback");
        }
        public ViewResult FAQs()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Write(string question, string answer)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            IServices<FAQs> rep = new GenericRepository<FAQs>(conn);
            FAQs r = new FAQs { question = question, answer = answer };
            rep.Add(r);
            return RedirectToAction("Read", "Feedback");
        }
      
        public ViewResult Read()
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            IServices<FAQs> rep = new GenericRepository<FAQs>(conn);
            List<FAQs> products = rep.GetAll().ToList();

            return View(products);
        }
        [Authorize(Policy = "AddPolicy")]
        public IActionResult Read1()
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            IServices<FAQs> rep = new GenericRepository<FAQs>(conn);
            List<FAQs> products = rep.GetAll().ToList();

            return View(products);
        }
        [Authorize(Policy = "AddPolicy")]
        public ViewResult UpdateFaqs()
        { return View(); ; }
        [HttpPost]
        public IActionResult Up(int id, string question, string answer)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            IServices<FAQs> rep = new GenericRepository<FAQs>(conn);
            FAQs r = new FAQs { Id = id, question = question, answer = answer };
            rep.Update(r);
            return RedirectToAction("UpdateFaqs", "FAQss");
        }
        [Authorize(Policy = "AddPolicy")]
        public ViewResult DeleteFaqs()
        { return View(); ; }
        [HttpPost]
        [Authorize(Policy = "AddPolicy")]
        public IActionResult del(int id)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            IServices<FAQs> rep = new GenericRepository<FAQs>(conn);
            FAQs r = new FAQs { Id = id };
            rep.Delete(id);
            return RedirectToAction("DeleteFaqs", "FAQss");
        }

    }
}
   