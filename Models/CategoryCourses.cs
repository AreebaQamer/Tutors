using E_Learning_Project_final.Models;
using Microsoft.Data.SqlClient;
using Dapper;
public class CategoryCourseViewModel
{
    public Category Category { get; set; }
    public List<Course> Course { get; set; }

    public List<Category> GetAllCategory()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = " SELECT * from  Category";

            return con.Query<Category>(query).ToList();
        }
    }
    public void AddCategory(Category category)
    {

        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "insert into category(name, description) values(@name,@description)";
            connection.Execute(query, category);
        }
    }

    public void UpdateCategory(Category category)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        using (SqlConnection connection = new SqlConnection(connectionString))

        {

            string query = "update category set name=@name, description=@description where id=@id";
            connection.Execute(query, category);
        }

    }
    public void DeleteCategory(int id)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "delete from category where id=@id";
            connection.Execute(query, new { Id = id });
        }

    }
}