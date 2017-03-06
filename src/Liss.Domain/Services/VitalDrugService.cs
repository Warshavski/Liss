using System;
using System.Collections.Generic;
using AutoMapper;
using Liss.Data;
using Liss.Domain.Lib;

namespace Liss.Domain.Services
{
	public class VitalDrugService : BaseService
	{
		public VitalDrugService(IUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
			
		}

		public List<Entities.VitalDrug> GetAllVitalDrugs()
		{
			var dbVitalDrugsList = UnitOfWork.VitalDrugRepository.GetAll();

			var mapper = AutoMapperConfig.VitalDrugMapper();
			var domainVitalDrugsList = 
				mapper.Map<List<Data.Poco.VitalDrug>, List<Entities.VitalDrug>>(dbVitalDrugsList);

			return domainVitalDrugsList;
		}

	}
}
