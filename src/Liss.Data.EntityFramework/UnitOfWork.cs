using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liss.Data.EntityFramework.Repository;
using Liss.Data.Poco;
using Liss.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Liss.Data.EntityFramework
{
	public sealed class UnitOfWork : IUnitOfWork
	{
		private readonly DbContext _dbContext = null;

		private IRepository<VitalDrug> _vitalDrugRepository = null;

		public UnitOfWork(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region IUnitOfWork members

		public IRepository<VitalDrug> VitalDrugRepository => _vitalDrugRepository 
			?? (_vitalDrugRepository = new Repository<VitalDrug>(_dbContext));	 

		public void Commit()
		{
			_dbContext.SaveChanges();
		}
		#endregion	

		#region IDisposable members
		public void Dispose()
		{
			_dbContext.Dispose();
		}
		#endregion

	}
}
