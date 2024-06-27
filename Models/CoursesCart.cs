
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//public class ShoppingCart
//{
//	// Add item to cart
//	public static void AddToCart(string itemId)
//	{
//		List<string> cart = GetCartItems();
//		cart.Add(itemId);
//		SaveCartItems(cart);
//	}

//	// Remove item from cart
//	public static void RemoveFromCart(string itemId)
//	{
//		List<string> cart = GetCartItems();
//		cart.Remove(itemId);
//		SaveCartItems(cart);
//	}

//	// Clear cart
//	public static void ClearCart()
//	{
//		SaveCartItems(new List<string>());
//	}

//	// Get items in cart
//	public static List<string> GetCartItems()
//	{
//		HttpCookie cartCookie = HttpContext.Current.Request.Cookies["Cart"];
//		if (cartCookie != null)
//		{
//			return cartCookie.Value.Split(',').ToList();
//		}
//		return new List<string>();
//	}

//	// Save cart items to cookie
//	private static void SaveCartItems(List<string> cartItems)
//	{
//		HttpCookie cartCookie = new HttpCookie("Cart");
//		cartCookie.Value = string.Join(",", cartItems);
//		cartCookie.Expires = DateTime.Now.AddDays(1); // Adjust expiration time as needed
//		HttpContext.Current.Response.Cookies.Add(cartCookie);
//	}
//	protected void btnAddToCart_Click(object sender, EventArgs e)
//	{
//		string itemId = "123"; // Retrieve item ID from the product being added
//		ShoppingCart.AddToCart(itemId);
//	}

//}