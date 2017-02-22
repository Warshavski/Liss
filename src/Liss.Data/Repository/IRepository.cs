using System.Collections.Generic;

namespace Liss.Data.Repository
{
	/// <summary>
	/// Generic repository
	/// </summary>
	/// <typeparam name="TEntity"></typeparam>
	public interface IRepository<TEntity> 
		where TEntity : class, new()
	{
		IEnumerable<TEntity> GetAll();
		TEntity GetById(int id);
		void Insert(TEntity entity);
		void Delete(int id);
		void Update(TEntity entity);
	}
}
