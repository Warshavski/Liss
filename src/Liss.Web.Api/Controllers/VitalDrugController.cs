using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Liss.Domain.Entities;
using Liss.Domain.Services;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Liss.Web.Api.Controllers
{
	[Route("api/[controller]")]
	public class VitalDrugController : Controller
	{
		private readonly VitalDrugService _vitalDrugService = null;

		public VitalDrugController(VitalDrugService vitalDrugService)
		{
			_vitalDrugService = vitalDrugService;
		}

		// GET: api/values
		[HttpGet]
		public IEnumerable<VitalDrug> Get()

		{
			return _vitalDrugService.GetAllVitalDrugs();
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}

		protected override void Dispose(bool disposing)
		{
			_vitalDrugService.Dispose();
			base.Dispose(disposing);
		}
	}
}
