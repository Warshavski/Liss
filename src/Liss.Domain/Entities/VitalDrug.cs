namespace Liss.Domain.Entities
{
	public sealed class VitalDrug
	{
		#region Properties.

		public  int Id { get; set; }

		public string Name { get; set; }

		public string DrugForm { get; set; }

		public string Manufacturer { get; set; }

		public decimal MaxPrice { get; set; }

		public string /*DateTime*/ RegistrationDate { get; set; }

		#endregion Properties.

		public VitalDrug()
		{
		}

		public VitalDrug(string drugName, string drugForm, string drugManufacturer,
			decimal drugMaxPrice, string drugRegistrationDate)
		{
			Name = drugName;
			DrugForm = drugForm;
			Manufacturer = drugManufacturer;
			MaxPrice = drugMaxPrice;
			RegistrationDate = drugRegistrationDate;
		}
	}
}
