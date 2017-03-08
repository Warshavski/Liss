using System.Collections.Generic;

using Liss.Data.Poco;

namespace Liss.Data.Repository
{
	public interface IVitalDrugRepository : IRepository<VitalDrug>
	{
		List<VitalDrug> SearchByPattern(string pattern);
	}
}
