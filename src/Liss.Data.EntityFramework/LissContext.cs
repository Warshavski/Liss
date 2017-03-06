using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liss.Data.Poco;
using Microsoft.EntityFrameworkCore;

namespace Liss.Data.EntityFramework
{
	public class LissContext : DbContext
	{
		public LissContext(DbContextOptions<LissContext> options)
			: base(options)
		{
			
		}

		public DbSet<VitalDrug> VitalDrugs { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<VitalDrug>()
				.Property(b => b.Id)
				.HasColumnName("NPP");

			modelBuilder.Entity<VitalDrug>()
				.Property(b => b.DrugForm)
				.HasColumnName("DRUGFORM");

			modelBuilder.Entity<VitalDrug>()
				.Property(b => b.Manufacturer)
				.HasColumnName("FIRM");

			modelBuilder.Entity<VitalDrug>()
				.Property(b => b.MaxPrice)
				.HasColumnName("MAXPRICE");

			modelBuilder.Entity<VitalDrug>()
				.Property(b => b.Name)
				.HasColumnName("TRADENAME");

			modelBuilder.Entity<VitalDrug>()
				.Property(b => b.RegistrationDate)
				.HasColumnName("REGDATE");

			modelBuilder.Entity<VitalDrug>()
				.ToTable("VITAL");
		}
	}
}
