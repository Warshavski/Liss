using System.Collections.Generic;

namespace Liss.Data.Repository
{
	/// <summary>
	/// Generic repository
	/// </summary>
	/// <typeparam name="TEntity">Type of the entity(poco)</typeparam>
	public interface IRepository<TEntity> 
		where TEntity : class, new()
	{
		/// <summary>
		/// Get all entities from the storage
		/// </summary>
		/// <returns></returns>
		List<TEntity> GetAll();

		/// <summary>
		/// Get entity from storage by it identificator
		/// </summary>
		/// <param name="id">Entity identificator</param>
		/// <returns></returns>
		TEntity GetById(int id);

		/// <summary>
		/// Add new entity to the storage
		/// </summary>
		/// <param name="entity">Entity</param>
		void Insert(TEntity entity);

		/// <summary>
		/// Delete entity from the storage
		/// </summary>
		/// <param name="id">Entity identificator</param>
		void Delete(int id);

		/// <summary>
		/// Update entity in the storege
		/// </summary>
		/// <param name="entity">Entity with new data</param>
		void Update(TEntity entity);
	}
}
