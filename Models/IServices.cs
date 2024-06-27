using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace E_Learning_Project_final.Models
{
	public interface IServices<TEntity>
	{

		public void Add( TEntity entity);
		public void Delete(int id);
	   public void Update(TEntity entity);
		IEnumerable<TEntity> GetAll();
		public void DeleteByString(string name);
		public TEntity FindById(int id);


    }
}