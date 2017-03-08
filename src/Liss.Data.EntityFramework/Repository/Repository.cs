using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liss.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Liss.Data.EntityFramework.Repository
{
	public class Repository<TEntity> : IRepository<TEntity>	
		where TEntity : class, new()
	{
		private readonly DbContext _dbContext = null;
		private readonly DbSet<TEntity> _dbTable = null;

		protected DbContext DbContext => _dbContext;
		protected DbSet<TEntity> DbTable => _dbTable;

		public Repository(DbContext dbContext)
		{
			_dbContext = dbContext;
			_dbTable = dbContext.Set<TEntity>();
		}

		public void Delete(int id)
		{
			var entity = _dbTable.Find(id);
			_dbTable.Remove(entity);
		}					  

		public List<TEntity> GetAll()
		{
			return _dbTable.ToList();
		}

		public TEntity GetById(int id)
		{
			return _dbTable.Find(id);
		}

		public void Insert(TEntity entity)
		{
			if (entity != null)
			{
				_dbTable.Add(entity);
			}
		}

		public void Update(TEntity entity)
		{
			if (entity != null)
			{
				_dbContext.Entry(entity).State = EntityState.Modified;
			}
		}
	}
}
