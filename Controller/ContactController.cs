using System.Net.Mail;
using E_Learning_Project_final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Tutors.Controllers
{
    public class ContactController : Controller
    {

        public ViewResult contact()
        {

            return View();
        }
    }
}
