using Microsoft.Data.SqlClient;

namespace E_Learning_Project_final.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }

        public void Add(Contact  cou)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "Insert into Contact (FirstName ,LastName , UserName,Email,Country, Gender ) values(@f,@l,@u,@e,@g)";
            SqlCommand select = new SqlCommand(query, conn);
            select.Parameters.AddWithValue("@f", cou.FirstName);
            select.Parameters.AddWithValue("@l", cou.LastName);
            select.Parameters.AddWithValue("@u", cou.UserName);
            select.Parameters.AddWithValue("@e", cou.Email);
            select.Parameters.AddWithValue("@c", cou.Country);
            select.Parameters.AddWithValue("@g", cou.Gender);
            select.ExecuteNonQuery();
            conn.Close();




        }
    }
}

