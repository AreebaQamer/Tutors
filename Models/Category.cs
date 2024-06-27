using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;

namespace E_Learning_Project_final.Models
{
	public class Category
	{
		public Category()
		{
			CategoryName = " ";
			
		}
		
		public int Id
		{
			get; set;
		}

		public string CategoryName
		{
			set; get;
		}
		public string Videos {  get; set; }
	}
}



