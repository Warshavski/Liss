using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liss.Data.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liss.Data.EntityFramework.Mappings
{
	public class VitalDrugMapper 
	{
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

		//public void CreateMappings(EntityTypeBuilder<VitalDrug> entityTypeBuilder)
		//{
		//	entityTypeBuilder.Property(b => b.Id).HasColumnName("NPP");
		//	entityTypeBuilder.Property(b => b.DrugForm).HasColumnName("DRUGFORM");
		//	entityTypeBuilder.Property(b => b.Manufacturer).HasColumnName("FIRM");
		//	entityTypeBuilder.Property(b => b.MaxPrice).HasColumnName("MAXPRICE");
		//	entityTypeBuilder.Property(b => b.Name).HasColumnName("TRADENAME");
		//	entityTypeBuilder.Property(b => b.RegistrationDate).HasColumnName("REGDATE");

		//	entityTypeBuilder.ToTable("VITAL");
		//}
	}
}
