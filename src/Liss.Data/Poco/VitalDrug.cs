using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liss.Data.Poco
{
	public sealed class VitalDrug
	{
		#region Properties.

		public int Id { get; set; }

		public string Name { get; set; }

		public string DrugForm { get; set; }

		public string Manufacturer { get; set; }

		public decimal MaxPrice { get; set; }

		public string /*DateTime*/ RegistrationDate { get; set; }

		#endregion Properties.
	}
}
