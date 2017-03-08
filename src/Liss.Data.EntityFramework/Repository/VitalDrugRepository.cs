using System.Linq;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Liss.Data.Poco;
using Liss.Data.Repository;

namespace Liss.Data.EntityFramework.Repository
{
	/// <summary>
	/// Represents vital drug repository implementation
	/// <see cref="IVitalDrugRepository"/>
	/// </summary>
	public class VitalDrugRepository : Repository<VitalDrug>, IVitalDrugRepository
	{
		/// <summary>
		/// .Ctor
		/// </summary>
		/// <param name="dbContext"></param>
		public VitalDrugRepository(DbContext dbContext)
			: base(dbContext)
		{

		}

		/// <summary>
		/// Search vital drugs by name pattern
		/// </summary>
		/// <param name="pattern">Name pattern</param>
		/// <returns></returns>
		public List<VitalDrug> SearchByPattern(string pattern)
		{
			return DbTable
				.Where(d => d.Name.Contains(pattern))
				.ToList();
		}
	}
}
