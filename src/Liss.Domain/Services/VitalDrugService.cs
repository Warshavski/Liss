using System;
using System.Collections.Generic;

using AutoMapper;

using Liss.Data;
using Liss.Domain.Lib;

namespace Liss.Domain.Services
{
	public class VitalDrugService : BaseService
	{
		private readonly IMapper _mapper = null;
		private IMapper Mapper => _mapper ?? AutoMapperConfig.VitalDrugMapper();

		public VitalDrugService(IUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
			
		}

		public List<Entities.VitalDrug> GetAllVitalDrugs()
		{
			var dbVitalDrugsList = UnitOfWork.VitalDrugRepository.GetAll();
 
			var domainVitalDrugsList =
				Mapper.Map<List<Data.Poco.VitalDrug>, List<Entities.VitalDrug>>(dbVitalDrugsList);

			return domainVitalDrugsList;
		}

		public List<Entities.VitalDrug> SearchVitalDrugs(string pattern)
		{
			var dbVitalDrugsList = UnitOfWork.VitalDrugRepository.SearchByPattern(pattern);

			var domainVitalDrugsList =
				Mapper.Map<List<Data.Poco.VitalDrug>, List<Entities.VitalDrug>>(dbVitalDrugsList);

			return domainVitalDrugsList;
		}

	}
}
