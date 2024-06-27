using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;

namespace E_Learning_Project_final.Models
{
	public class Course
	{
       
        public int CourseId {  get; set; }

		public string Name
		{
			set; get;
		}
		public string Description
		{
			set; get;

		}
		public string Price
		{
			set; get;
		}
		public string Videos
		{ set; get; }
        public int Id        
		{ set; get; }
		public string CateName {  set; get; }


    }
}



