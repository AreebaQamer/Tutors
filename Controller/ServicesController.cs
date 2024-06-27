using System.Net.Http.Headers;
using System.Security.Cryptography;
using E_Learning_Project_final.Data.Migrations;
using E_Learning_Project_final.Models;
using Home.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using NuGet.Versioning;
namespace Services.Controllers
{
	public class ServicesController : Controller
	{

		//view result 
		public ViewResult GeneralLanguages()
		{
			return View();
		}

		public ViewResult Web()
		{
			return View();
		}
		public ViewResult Programming()
		{
			return View();
		}
		public ViewResult BussinessManagement()
		{
			return View();
		}
		public ViewResult GraphicDesigning()
		{
			return View();
		}

		public ViewResult AppDevelopment()
		{
			return View();
		}


	}  
}

