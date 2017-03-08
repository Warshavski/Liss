namespace Liss.Domain.Entities
{
	/// <summary>
	/// Represents vitat drug entity
	/// </summary>
	public sealed class VitalDrug
	{
		#region Properties.

		/// <summary>
		/// Vital drug identificator(order)
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Drug name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Drug form
		/// </summary>
		public string DrugForm { get; set; }

		/// <summary>
		/// Drug manufacturer name
		/// </summary>
		public string Manufacturer { get; set; }

		/// <summary>
		/// The maximum available price
		/// </summary>
		public decimal MaxPrice { get; set; }

		/// <summary>
		/// Registration date of the drug
		/// </summary>
		public string /*DateTime*/ RegistrationDate { get; set; }

		#endregion Properties.

		/// <summary>
		/// .Ctor (default for AutoMapper)
		/// </summary>
		public VitalDrug()
		{
		}

		/// <summary>
		/// .Ctor (main)
		/// </summary>
		/// <param name="drugName">Vital drug name</param>
		/// <param name="drugForm">Vital drug drug form</param>
		/// <param name="drugManufacturer">Vital drug manufacturer name</param>
		/// <param name="drugMaxPrice">The maximum available price</param>
		/// <param name="drugRegistrationDate">Registration date of the vital drug</param>
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
