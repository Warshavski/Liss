using AutoMapper;

namespace Liss.Domain.Lib
{
	/// <summary>
	/// Class that contains all AutoMapper configurations
	/// </summary>
	public class AutoMapperConfig
	{
		/// <summary>
		/// Vital drug mappings config
		/// </summary>
		/// <returns></returns>
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
