using System;

using Liss.Data.Poco;
using Liss.Data.Repository;

namespace Liss.Data
{
	/// <summary>
	/// Represents unit
	/// </summary>
	public interface IUnitOfWork : IDisposable
	{
		/// <summary>
		/// Vital drug repository
		/// <see cref="VitalDrug"/>
		/// </summary>
		IVitalDrugRepository VitalDrugRepository { get; }

		/// <summary>
		/// Commit(save) transaction
		/// </summary>
		void Commit();
	}
}
