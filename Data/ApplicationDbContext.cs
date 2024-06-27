
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using E_Learning_Project_final.Models;
using E_Learning_Project_final.Data.Migrations;

namespace E_Learning_Project_final.Data
{
	public class ApplicationDbContext : IdentityDbContext<MyUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

    }
}
