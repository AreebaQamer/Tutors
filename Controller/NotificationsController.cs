using Microsoft.AspNetCore.Mvc;


namespace E_Learning_Project_final.Controllers
{
	public class NotificationsController : Controller
	{
		public IActionResult ShowNotifications() { 
			return View();
		}

	}
}


