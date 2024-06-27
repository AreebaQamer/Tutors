//using System.Diagnostics.Contracts;
//using System.Security.Cryptography;
//using E_Learning_Project_final.Data.Migrations;
//using Microsoft.Data.SqlClient;

//namespace E_Learning_Project_final.Models
//{


    

////public class Display
////{


////	get courses
////	public List<Course> GetCourses()
////	{
////		List<Course> products = new List<Courses>();
////		string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
////		SqlConnection con = new SqlConnection(connectionString);
////		con.Open();
////		string query = " SELECT * from  Courses";

////		SqlCommand cmd = new SqlCommand(query, con);
////		SqlDataReader dr = cmd.ExecuteReader();


////		while (dr.Read())
////		{
////			Courses p = new Courses
////			{

////				Name = dr.GetString(1),
////				Description = dr.GetString(2),
////				Price = dr.GetString(3),
////				Videos = dr.GetString(4)
////			};
////			products.Add(p);

////		}
////		return products;
////	}
////	get category
////	public List<Category> GetCategory()
////	{
////		List<Category> products = new List<Category>();
////		string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
////		SqlConnection con = new SqlConnection(connectionString);
////		con.Open();
////		string query = " SELECT * from  Category";

////		SqlCommand cmd = new SqlCommand(query, con);
////		SqlDataReader dr = cmd.ExecuteReader();


////		while (dr.Read())
////		{
////			Category s = new Category
////			{

////				CategoryName = dr.GetString(1),
////				Videos = dr.GetString(2)

////			};
////			products.Add(s);

////		}
////		return products;
////	}


////	public void DeleteCourse(int courseId)
////	{
////		string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

////		using (SqlConnection con = new SqlConnection(connectionString))
////		{
////			con.Open();
////			string query = "DELETE FROM Courses WHERE Id = @Id";
////			SqlCommand cmd = new SqlCommand(query, con);
////			cmd.Parameters.AddWithValue("@Id", courseId);

////			int rowsAffected = cmd.ExecuteNonQuery();
////			if (rowsAffected > 0)
////			{
////				Console.WriteLine($"Course with ID '{courseId}' has been deleted");
////			}
////			else
////			{
////				Console.WriteLine($"No course found with ID '{courseId}'");
////			}
////		}

////	}


////public void Update(Course product)
////{
////	string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
////	using (SqlConnection connection = new SqlConnection(connectionString))
////	{
////		string query = "UPDATE [dbo].[GeneralLanguages] SET " +
////					   "[Name] = @Name, " +
////					   "[Description] = @Description, " +
////						 "[Price] = @Price, " +

////					   "[Images] = @ImagePath WHERE [Name] = @Name";

////		SqlCommand command = new SqlCommand(query, connection);
////		command.Parameters.AddWithValue("@Name", product.Name);
////		command.Parameters.AddWithValue("@Description", product.Description);

////		command.Parameters.AddWithValue("@Price", product.Price);
////		command.Parameters.AddWithValue("@ImagePath", product.I);
////		Assuming CategoryId is a property of Product

////				connection.Open();
////		int rowsAffected = command.ExecuteNonQuery();
////		connection.Close();

////	}
////}
////public void DeleteByName(string name)
////{
////	string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
////	SQL query with parameter placeholder
////			string query = "DELETE FROM GeneralLanguages WHERE Name = @na";

////	using (SqlConnection connection = new SqlConnection(connectionString))
////	{
////		using (SqlCommand command = new SqlCommand(query, connection))
////		{
////			Add parameter for the ID


////		   command.Parameters.AddWithValue("@na", name);

////					try
////				{
////					connection.Open();
////					int rowsAffected = command.ExecuteNonQuery();

////				}
////				catch (SqlException ex)
////				{
////					Console.WriteLine("Error deleting course: " + ex.Message);
////				}
////		}
////	}
////}


////	}
////}


