using System;
using E_Learning_Project_final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using E_Learning_Project_final.Data;
using Microsoft.AspNetCore.Authorization;

namespace E_Learning_Project_final.Controllers
{
	public class VideosController : Controller
	{
		private readonly ILogger<VideosController> _logger;
		private readonly IWebHostEnvironment _env;


		public VideosController(ILogger<VideosController> logger, IWebHostEnvironment env)
		{
			_logger = logger;
			_env = env;
		}
		//private const string CartSessionKey = "Videos";
		//private readonly ApplicationDbContext _context;

		//public VideosController(ApplicationDbContext context)
		//{
		//	_context = context;
		//}

		////[Authorize]

		//public IActionResult AddToCart(int id)
		//{


		//	HttpContext.Session.SetInt32("Id", id);

		//	var cart = GetCart();

		//	var cartItem = cart.FirstOrDefault(ci => ci.Id == id);

		//	if (cartItem != null)
		//	{
		//		cartItem.Quantity += 1;
		//	}
		//	else
		//	{
		//		cart.Add(new CartItem
		//		{
		//			Id = id,
		//			Quantity = 1
		//		});
		//	}

		//	SaveCart(cart);

		//	return RedirectToAction("ViewVideo", "Videos");

		//}
		//[HttpPost]
		//public async Task<IActionResult> Cart(int id)
		//{
		//	var user = User;

		//	if (user.Identity.IsAuthenticated)
		//	{
		//		var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

		//		HttpContext.Session.SetString("UserId", userId);
		//		HttpContext.Session.SetInt32("Id", id);

		//		string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
		//		SqlConnection con = new SqlConnection(conn);
		//		con.Open();
		//		string query = "SELECT * FROM Videos where Id=@id";
		//		SqlCommand cmd = new SqlCommand(query, con);

		//		cmd.Parameters.AddWithValue("@id", id);
		//		SqlDataReader dr = cmd.ExecuteReader();
		//		Videos p = new Videos();
		//		while (dr.Read())
		//		{
		//			p.Title = dr.GetString(1);

		//			p.Url = dr.GetString(2);
		//		}

		//		var cart = GetCart();

		//		var cartItem = cart.FirstOrDefault(ci => ci.Id == id);

		//		if (cartItem != null)
		//		{
		//			cartItem.Quantity += 1;
		//		}
		//		else
		//		{
		//			cart.Add(new CartItem
		//			{
		//				Id = id,
		//				Quantity = 1,
		//				Name = p.Title,
		//				Image = p.Url
		//			});
		//		}

		//		SaveCart(cart);

		//		return RedirectToAction("ViewVideo", "Videos");
		//	}

		//	return RedirectToAction("Login", "Account");
		//}

		//public IActionResult ViewVideo()
		//{
		//	var cart = GetCart();
		//	return View(cart);
		//}

		//private List<CartItem> GetCart()
		//{
		//	var cartJson = HttpContext.Session.GetString(CartSessionKey);
		//	if (string.IsNullOrEmpty(cartJson))
		//	{
		//		return new List<CartItem>();
		//	}

		//	return JsonSerializer.Deserialize<List<CartItem>>(cartJson);
		//}

		//private void SaveCart(List<CartItem> cart)
		//{
		//	var cartJson = JsonSerializer.Serialize(cart);
		//	HttpContext.Session.SetString(CartSessionKey, cartJson);
		//}

		//public IActionResult Checkout()
		//{
		//	var cart = GetCart();
		//	var totalAmount = cart.Sum(item => item.TotalPrice);

		//	ViewBag.TotalAmount = totalAmount;

		//	return View(cart);
		//}
		//public ViewResult ConfirmOrder()
		//{
		//	return View();
		//}
		//public IActionResult DeleteCart(int? deleteItemId)
		//{
		//	var cart = GetCart();

		//	if (deleteItemId.HasValue)
		//	{
		//		var itemToRemove = cart.FirstOrDefault(ci => ci.Id == deleteItemId.Value);
		//		if (itemToRemove != null)
		//		{
		//			cart.Remove(itemToRemove);
		//			SaveCart(cart);
		//		}
		//	}

		//	return View(cart);
		//}

		public ViewResult add()
		{
			return View();
		}
		public ViewResult View()
		{



			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
			IServices<Videos> rep = new GenericRepository<Videos>(conn);
			List<Videos> products = rep.GetAll().ToList();
			return View(products);

		}
		[HttpPost]
		public IActionResult Add1(string name, IFormFile videos)
		{
			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
			string fileName = Path.GetFileName(videos.FileName);
			string fileExtension = Path.GetExtension(videos.FileName);
			Videos c = new Videos
			{

				Title = name,
				Url = fileName,
			};
			IServices<Videos> repository = new GenericRepository<Videos>(conn);
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
			return RedirectToAction("View", "Videos");

		}
	}
}







