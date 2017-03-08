using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liss.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Liss.Data.EntityFramework.Repository
{
	/// <summary>
	/// Represents generic repository interface implementation
	/// </summary>
	/// <see cref="IRepository{TEntity}"/>
	/// <typeparam name="TEntity">Type of poco</typeparam>
	public class Repository<TEntity> : IRepository<TEntity>	
		where TEntity : class, new()
	{
		private readonly DbContext _dbContext = null;
		private readonly DbSet<TEntity> _dbTable = null;

		/// <summary>
		/// Entity framework data base context
		/// </summary>
		protected DbContext DbContext => _dbContext;

		/// <summary>
		/// Entity framework DbSet
		/// </summary>
		protected DbSet<TEntity> DbTable => _dbTable;

		/// <summary>
		/// .Ctor
		/// </summary>
		/// <param name="dbContext">Entity framework data base context</param>
		public Repository(DbContext dbContext)
		{
			_dbContext = dbContext;
			_dbTable = dbContext.Set<TEntity>();
		}

		/// <summary>
		/// Delete entity from the storage
		/// </summary>
		/// <param name="id">Entity identificator</param>
		public void Delete(int id)
		{
			var entity = _dbTable.Find(id);
			_dbTable.Remove(entity);
		}

		/// <summary>
		/// Get all entities from the storage
		/// </summary>
		/// <returns></returns>
		public List<TEntity> GetAll()
		{
			return _dbTable.ToList();
		}

		/// <summary>
		/// Get entity from storage by it identificator
		/// </summary>
		/// <param name="id">Entity identificator</param>
		/// <returns></returns>
		public TEntity GetById(int id)
		{
			return _dbTable.Find(id);
		}

		/// <summary>
		/// Add new entity to the storage
		/// </summary>
		/// <param name="entity">Entity</param>
		public void Insert(TEntity entity)
		{
			if (entity != null)
			{
				_dbTable.Add(entity);
			}
		}

		/// <summary>
		/// Update entity in the storege
		/// </summary>
		/// <param name="entity">Entity with new data</param>
		public void Update(TEntity entity)
		{
			if (entity != null)
			{
				_dbContext.Entry(entity).State = EntityState.Modified;
			}
		}
	}
}
