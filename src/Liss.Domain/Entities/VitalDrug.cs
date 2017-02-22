namespace Liss.Domain.Entities
{
	public sealed class VitalDrug
	{
		#region Properties.

		public string Name { get; private set; }

		public string DrugForm { get; private set; }

		public string Manufacturer { get; private set; }

		public decimal MaxPrice { get; private set; }

		public string /*DateTime*/ RegistrationDate { get; private set; }

		#endregion Properties.

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
