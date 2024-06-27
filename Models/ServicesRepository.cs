


using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using E_Learning_Project_final.Data.Migrations;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace E_Learning_Project_final.Models
{
    public class ServicesRepository
    {


        public Course Get()
        {
            return new Course();
        }
        public List<Course> GetCourse()
        {
            List<Course> products = new List<Course>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = " SELECT * from  Course";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                Course p = new Course
                {

                    Name = dr.GetString(1),
                    Description = dr.GetString(2),
                    Price = dr.GetString(3),
                    Videos = dr.GetString(4)
                };
                products.Add(p);

            }
            return products;
        }
        public List<Category> GetCategory()
        {
            List<Category> products = new List<Category>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = " SELECT * from  Category";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                Category p = new Category
                {

                    CategoryName = dr.GetString(1),

                    Videos = dr.GetString(2)
                };
                products.Add(p);

            }
            return products;
        }

        public List<Course> GetCourse1()
        {
            List<Course> products = new List<Course>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $" SELECT p.CourseId , p.Name, p.Description," +
                $" p.Price, p.Videos FROM Course p  WHERE p.CateName = 'gl' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Course p = new Course();
                if (!dr.IsDBNull(0)) // Check if the column value is not NULL
                {
                    p.CourseId = dr.GetInt32(0); // Retrieve the integer value from the first column
                }
                p.CourseId = dr.GetInt32(0);
                p.Name = dr.GetString(1);
                p.Description = dr.GetString(2);
                p.Price = dr.GetString(3);
                p.Videos = dr.GetString(4);
                products.Add(p);



            }
            return products;
        }
        public List<Course> GetCourse2()
        {
            List<Course> products = new List<Course>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $" SELECT p.CourseId, p.Name, p.Description," +
                $" p.Price,  p.Videos FROM Course p  WHERE p.CateName = 'web'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Course p = new Course();
                if (!dr.IsDBNull(0)) // Check if the column value is not NULL
                {
                    p.CourseId = dr.GetInt32(0); // Retrieve the integer value from the first column
                }
                p.CourseId = dr.GetInt32(0);
                p.Name = dr.GetString(1);
                p.Description = dr.GetString(2);
                p.Price = dr.GetString(3);
                p.Videos = dr.GetString(4);
                products.Add(p);

            }
            return products;
        }
        public List<Course> GetCourse3()
        {
            List<Course> products = new List<Course>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $" SELECT p.CourseId, p.Name, p.Description," +
              $" p.Price,  p.Videos FROM Course p  WHERE p.CateName ='pro' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Course p = new Course();
                if (!dr.IsDBNull(0)) // Check if the column value is not NULL
                {
                    p.CourseId = dr.GetInt32(0); // Retrieve the integer value from the first column
                }
                p.CourseId = dr.GetInt32(0);
                p.Name = dr.GetString(1);
                p.Description = dr.GetString(2);
                p.Price = dr.GetString(3);
                p.Videos = dr.GetString(4);
                products.Add(p);

            }
            return products;
        }
        public List<Course> GetCourse4()
        {
            List<Course> products = new List<Course>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $" SELECT p.CourseId, p.Name, p.Description," +
              $" p.Price,  p.Videos FROM Course p  WHERE p.CateName = 'buss'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Course p = new Course();
                if (!dr.IsDBNull(0)) // Check if the column value is not NULL
                {
                    p.CourseId = dr.GetInt32(0); // Retrieve the integer value from the first column
                }
                p.CourseId = dr.GetInt32(0);
                p.Name = dr.GetString(1);
                p.Description = dr.GetString(2);
                p.Price = dr.GetString(3);
                p.Videos = dr.GetString(4);
                products.Add(p);

            }
            return products;
        }
        public List<Course> GetCourse5()
        {
            List<Course> products = new List<Course>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $" SELECT p.CourseId, p.Name, p.Description," +
              $" p.Price,  p.Videos FROM Course p  WHERE p.CateName = 'graph'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Course p = new Course();
                if (!dr.IsDBNull(0)) // Check if the column value is not NULL
                {
                    p.CourseId = dr.GetInt32(0); // Retrieve the integer value from the first column
                }
                p.CourseId = dr.GetInt32(0);
                p.Name = dr.GetString(1);
                p.Description = dr.GetString(2);
                p.Price = dr.GetString(3);
                p.Videos = dr.GetString(4);
                products.Add(p);

            }
            return products;
        }
        public List<Course> GetCourse6()
        {
            List<Course> products = new List<Course>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $" SELECT p.CourseId, p.Name, p.Description," +
                  $" p.Price,  p.Videos FROM Course p  WHERE p.CateName = 'app'";


            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Course p = new Course();
                if (!dr.IsDBNull(0)) // Check if the column value is not NULL
                {
                    p.CourseId = dr.GetInt32(0); // Retrieve the integer value from the first column
                }
                p.CourseId = dr.GetInt32(0);
                p.Name = dr.GetString(1);
                p.Description = dr.GetString(2);
                p.Price = dr.GetString(3);
                p.Videos = dr.GetString(4);
                products.Add(p);

            }
            return products;
        }


        public List<Feed> GetFeeds()
        {
            List<Feed> products = new List<Feed>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = " SELECT * from  Feed";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                Feed s = new Feed
                {

                    Name = dr.GetString(0),
                    Email = dr.GetString(1),
                    Satisfaction = dr.GetString(2),
                    Suggestions = dr.GetString(3)


                };
                products.Add(s);

            }
            return products;
        }

        public List<Videos> GetVideo1()
        {
            List<Videos> videos = new List<Videos>();

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=1";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Videos video = new Videos();
                if (!dr.IsDBNull(0))
                {
                    video.Id = dr.GetInt32(0);
                }
                video.Title = dr.GetString(1);
                video.Url = dr.GetString(2);
                videos.Add(video);
            }

            con.Close();
            return videos;
        }
		public List<Videos> GetVideo2(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
			string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=2";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}
		public List<Videos> GetVideo3(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
			string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=3";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}
		public List<Videos> GetVideo4(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
			string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=4";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}
		public List<Videos> GetVideo5(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
			string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=5" +
                $"";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}

		public List<Videos> GetVideo6(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
			string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=6";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}
		public List<Videos> GetVideo7(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
			string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=7";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}
		public List<Videos> GetVideo8(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
			string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=8";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}
		public List<Videos> GetVideo9(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
            string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=9";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}
		public List<Videos> GetVideo10(int courseId)
		{
			List<Videos> videos = new List<Videos>();

			string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			SqlConnection con = new SqlConnection(conn);
			con.Open();
			string query = $"SELECT v.Id, v.Title, v.Url FROM Videos where v.Id=10";

			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@CourseId", courseId);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Videos video = new Videos();
				if (!dr.IsDBNull(0))
				{
					video.Id = dr.GetInt32(0);
				}
				video.Title = dr.GetString(1);
				video.Url = dr.GetString(2);
				videos.Add(video);
			}

			con.Close();
			return videos;
		}
		public void delete()
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection c = new SqlConnection(conn);
            c.Open();
            //IServices<Course> rep = new GenericRepository<Course>(conn);
            //rep.Delete(id);
            //return RedirectToAction("Course", "ServicesCategory");
            string query = "Delete from Course where CourseId=23";
            SqlCommand cmd = new SqlCommand(query, c);
            cmd.ExecuteNonQuery();
        }


        public List<Videos> GetVideosByCartItems(List<int> cartItems)
        {
            List<Videos> videos = new List<Videos>();
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                string query = $"SELECT * FROM Videos WHERE id IN ({string.Join(",", cartItems)})";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Videos video = new Videos
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Url = reader.GetString(2)
                        };

                        videos.Add(video);
                    }
                }
            }

            return videos;
        }
        public List<Videos> GetVideos(Videos video)
        {

            List<Videos> products = new List<Videos>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = " SELECT * from  Videos";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                Videos p = new Videos();
                if (!dr.IsDBNull(0)) // Check if the column value is not NULL
                {
                    p.Id = dr.GetInt32(0); // Retrieve the integer value from the first column
                }
                p.Id = dr.GetInt32(0);
                p.Title = dr.GetString(1);

                p.Url = dr.GetString(2);
                products.Add(p);

            }
            return products;
        }

    }
}

    

