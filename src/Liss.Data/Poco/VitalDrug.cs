
namespace Liss.Data.Poco
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
	}
}
