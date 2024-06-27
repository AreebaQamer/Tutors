using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace E_Learning_Project_final.Models
{
    public class GenericRepository<TEntity> : IServices<TEntity>
    {
        private readonly string _connectionString;

        public GenericRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(TEntity entity)
        {
                var tableName = typeof(TEntity).Name;
                var properties = typeof(TEntity).GetProperties().Where(p => p.Name != "Id");
                var columnNames = string.Join(",", properties.Select(p => p.Name));
                var parameters = string.Join(",", properties.Select(p => "@" + p.Name));
                var query = $"INSERT INTO [{tableName}] ({columnNames}) VALUES ({parameters})";
			using (var connection = new SqlConnection(_connectionString))
			{
                connection.Open();

				connection.Execute(query, entity);
            }
        }
     
        public void Update(TEntity entity)
        {
       
                var tableName = typeof(TEntity).Name;
			     var primaryKey = "CourseId";

			var properties = typeof(TEntity).GetProperties().Where(p => p.Name != primaryKey);
                var setClause = string.Join(",", properties.Select(p => $"{p.Name} = @{p.Name}"));
                var query = $"UPDATE [{tableName}] SET {setClause} WHERE {primaryKey} = @{primaryKey}";
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				connection.Execute(query, entity);
            }
        }
		public void Delete(int id)
		{
			var tablename = typeof(TEntity).Name; 
			var query = $"DELETE FROM [{tablename}] WHERE CourseId = @id";
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var cmd = new SqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@id", id);
				connection.Execute(query, new { Id = id });
			}


		}
		public void DeleteByString(string name)
		{
			var tablename = typeof(TEntity).Name;
			var query = $"DELETE FROM [{tablename}] WHERE Name = @name";
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var cmd = new SqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@name", name);
				connection.Execute(query, new { Name = name});
			}


		}



		public IEnumerable<TEntity> GetAll()
		{
			var tableName = typeof(TEntity).Name;
			var query = $"SELECT * FROM [{tableName}]";

			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				return connection.Query<TEntity>(query).ToList();
			}
		}
        public TEntity FindById(int id)
        {
            var tablename = typeof(TEntity).Name;
            var query = $"SELECT * FROM {tablename} WHERE CourseId = @Id";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var entity = Activator.CreateInstance<TEntity>();
                    foreach (var prop in typeof(TEntity).GetProperties())
                    {
                        var value = reader[prop.Name];
                        prop.SetValue(entity, value == DBNull.Value ? null : value);
                    }
                    return entity;  // Corrected the typo here
                }
            }
            return default(TEntity);
        }
    }
}
