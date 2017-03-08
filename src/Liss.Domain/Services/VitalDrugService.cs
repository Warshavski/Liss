using System.Collections.Generic;

using AutoMapper;

using Liss.Data;
using Liss.Domain.Lib;

namespace Liss.Domain.Services
{
	/// <summary>
	/// Represents service class for vital drug entity
	/// <see cref="Entities.VitalDrug"/>
	/// </summary>
	public class VitalDrugService : BaseService<Entities.VitalDrug>
	{
		private readonly IMapper _mapper = null;

		/// <summary>
		/// AutoMapper instance
		/// <see cref="AutoMapperConfig"/>
		/// </summary>
		private IMapper Mapper => _mapper ?? AutoMapperConfig.VitalDrugMapper();

		/// <summary>
		/// .Ctor
		/// </summary>
		/// <param name="unitOfWork"></param>
		public VitalDrugService(IUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
			
		}

		#region Public interface methods

		/// <summary>
		/// Get all vital drugs 
		/// </summary>
		/// <returns></returns>
		public List<Entities.VitalDrug> GetAllVitalDrugs()
		{
			var dbVitalDrugsList = UnitOfWork.VitalDrugRepository.GetAll();

			var domainVitalDrugsList = CreateDomainEntitiesList(Mapper, dbVitalDrugsList);

			return domainVitalDrugsList;
		}

		/// <summary>
		/// Get vital drugs that name contains the desired pattern
		/// </summary>
		/// <param name="pattern">Name pattern</param>
		/// <returns></returns>
		public List<Entities.VitalDrug> SearchVitalDrugs(string pattern)
		{
			var dbVitalDrugsList = UnitOfWork.VitalDrugRepository.SearchByPattern(pattern);

			var domainVitalDrugsList = CreateDomainEntitiesList(Mapper, dbVitalDrugsList);

			return domainVitalDrugsList;
		}

		#endregion
	}
}
