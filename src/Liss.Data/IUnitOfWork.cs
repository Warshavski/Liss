using System;

using Liss.Data.Poco;
using Liss.Data.Repository;

namespace Liss.Data
{
	public interface IUnitOfWork : IDisposable
	{
		IVitalDrugRepository VitalDrugRepository { get; }
		void Commit();
	}
}
