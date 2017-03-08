using Microsoft.EntityFrameworkCore;

using Liss.Data.EntityFramework.Repository;
using Liss.Data.Repository;

namespace Liss.Data.EntityFramework
{
	public sealed class UnitOfWork : IUnitOfWork
	{
		#region Class members

		private readonly DbContext _dbContext = null;

		private IVitalDrugRepository _vitalDrugRepository = null;

		public UnitOfWork(LissContext dbContext)
		{
			_dbContext = dbContext;
		}

		#endregion

		#region IUnitOfWork members

		public IVitalDrugRepository VitalDrugRepository => _vitalDrugRepository 
			?? (_vitalDrugRepository = new VitalDrugRepository(_dbContext));

		public void Commit()
		{
			_dbContext.SaveChanges();
		}

		#endregion	

		#region IDisposable members

		public void Dispose()
		{
			_dbContext?.Dispose();
		}

		#endregion
	}
}
