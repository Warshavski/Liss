using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Liss.Data.Poco;
using Liss.Data.Repository;

namespace Liss.Data
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<VitalDrug> VitalDrugRepository { get; }
		void Commit();
	}
}
