using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
namespace E_Learning_Project_final.Models
{
    public class Feed
    {

        public string Name {  get; set; }

          public string Email { get; set; }
            public string Satisfaction { get; set; }

         public string Suggestions{  get; set; }
    }
}
