using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
public class MyUser : IdentityUser
{
	public MyUser()
	{
		FirstName = " ";
		LastName = " ";
	}
	public string FirstName { get; set; }
	public string LastName { get; set; }
	
}
