using AutoMapper;

namespace Liss.Domain.Lib
{
	public class AutoMapperConfig
	{
		public static IMapper VitalDrugMapper()
		{
			return new MapperConfiguration(
				cfg =>
				{
					cfg.CreateMap<Data.Poco.VitalDrug, Entities.VitalDrug>();
				})
				.CreateMapper();
		}
	}
}
