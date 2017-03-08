using System.Collections.Generic;

using Liss.Data.Poco;

namespace Liss.Data.Repository
{
	/// <summary>
	/// Represents interface for the VitalDrug repository
	/// </summary>
	public interface IVitalDrugRepository : IRepository<VitalDrug>
	{
		/// <summary>
		/// Search vital drugs by name pattern
		/// </summary>
		/// <param name="pattern">Name pattern</param>
		/// <returns></returns>
		List<VitalDrug> SearchByPattern(string pattern);
	}
}
