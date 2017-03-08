using System.Linq;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Liss.Data.Poco;
using Liss.Data.Repository;

namespace Liss.Data.EntityFramework.Repository
{
	public class VitalDrugRepository : Repository<VitalDrug>, IVitalDrugRepository
	{
		public VitalDrugRepository(DbContext dbContext)
			: base(dbContext)
		{

		}

		public List<VitalDrug> SearchByPattern(string pattern)
		{
			return DbTable
				.Where(d => d.Name.Contains(pattern))
				.ToList();
		}
	}
}
