using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Liss.Data.Poco;

namespace Liss.Data.EntityFramework.Mappings
{
	/// <summary>
	/// Represents data base mapping configuration for vital drug poco
	/// </summary>
	public class VitalDrugMapper 
	{
		/// <summary>
		/// Create mappings between data base table and vital drug poco class
		/// </summary>
		/// <see cref="DbContext"/>
		/// <param name="entityBuilder">Entity framework EntityTypeBuilder</param>
		public static void CreateMappings(EntityTypeBuilder<VitalDrug> entityBuilder)
		{
			entityBuilder.Property(b => b.Id).HasColumnName("NPP");
			entityBuilder.Property(b => b.DrugForm).HasColumnName("DRUGFORM");
			entityBuilder.Property(b => b.Manufacturer).HasColumnName("FIRM");
			entityBuilder.Property(b => b.MaxPrice).HasColumnName("MAXPRICE");
			entityBuilder.Property(b => b.Name).HasColumnName("TRADENAME");
			entityBuilder.Property(b => b.RegistrationDate).HasColumnName("REGDATE");

			entityBuilder.ToTable("VITAL");
		}
	}
}
