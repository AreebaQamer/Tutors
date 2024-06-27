using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using E_Learning_Project_final.Data;
using System.Security.Claims;
using E_Learning_Project_final.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;


namespace FlowerWeb.Controllers
{
    public class AddToCartController : Controller
    {
        private const string CartSessionKey = "Cart";
        private readonly ApplicationDbContext _context;

        public AddToCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult AddToCart(int id)
        {

            HttpContext.Session.SetInt32("Id", id);

            var cart = GetCart();

            var cartItem = cart.FirstOrDefault(ci => ci.CourseId == id);

            if (cartItem != null)
            {
                cartItem.Quantity += 1;
            }
            else
            {
                cart.Add(new CartItem
                {
                    CourseId = id,
                    Quantity = 1
                });
            }

            SaveCart(cart);

            return RedirectToAction("ViewCarts", "AddToCart");

        }



        public IActionResult Index()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            IServices<Course> rep = new GenericRepository<Course>(connectionString);
            List<Course> products = rep.GetAll().ToList();
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> Cart(int id)
        {
            var user = User;

            if (user.Identity.IsAuthenticated)
            {
                var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                HttpContext.Session.SetString("UserId", userId);
                HttpContext.Session.SetInt32("Id", id);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * FROM Course where CourseId=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();
                Course p = new Course();
                while (dr.Read())
                {
                    p.Name = dr.GetString(1);
                    p.Price = dr.GetString(3);
                    p.Videos = dr.GetString(4);
                }

                var cart = GetCart();

                var cartItem = cart.FirstOrDefault(ci => ci.CourseId == id);

                if (cartItem != null)
                {
                    cartItem.Quantity += 1;
                }
                else
                {
                    cart.Add(new CartItem
                    {
                        CourseId = id,
                        Quantity = 1,
                        Price = p.Price,
                        Name = p.Name,
                        Image = p.Videos
                    });
                }

                SaveCart(cart);

                return RedirectToAction("ViewCarts", "AddToCart");
            }

            return RedirectToAction("Login", "Account");
        }

        public IActionResult ViewCarts()
        {
            var cart = GetCart();
            return View(cart);
        }

        private List<CartItem> GetCart()
        {
            var cartJson = HttpContext.Session.GetString(CartSessionKey);
            if (string.IsNullOrEmpty(cartJson))
            {
                return new List<CartItem>();
            }

            return JsonSerializer.Deserialize<List<CartItem>>(cartJson);
        }

        private void SaveCart(List<CartItem> cart)
        {
            var cartJson = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString(CartSessionKey, cartJson);
        }
        public IActionResult Checkout()
        {
            var cart = GetCart();
            var totalAmount = cart.Sum(item => item.TotalPrice);

            ViewBag.TotalAmount = totalAmount;

            return View(cart);
        }
        public ViewResult ConfirmOrder()
        {
            return View();
        }
        public IActionResult DeleteCart(int? deleteItemId)
        {
            var cart = GetCart();

            if (deleteItemId.HasValue)
            {
                var itemToRemove = cart.FirstOrDefault(ci => ci.CourseId == deleteItemId.Value);
                if (itemToRemove != null)
                {
                    cart.Remove(itemToRemove);
                    SaveCart(cart);
                }
            }

            return View(cart);
        }
        [HttpPost]
        public IActionResult AddInfo(string name, string email, string institute, string city, string zip)
        {


            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            Checkout c = new Checkout
            {
                Name = name,
                Email = email,
                Institute = institute,
                City = city,
                Zip = zip
            };
            IServices<Checkout> repository = new GenericRepository<Checkout>(conn);
            repository.Add(c);

            return RedirectToAction("ConfirmOrder", "AddToCart");
        }

    }
}
