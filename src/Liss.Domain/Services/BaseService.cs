using System;
using Liss.Data;

namespace Liss.Domain.Services
{
	public class BaseService : IDisposable
	{
		private readonly IUnitOfWork _unitOfWork = null;

		protected IUnitOfWork UnitOfWork => _unitOfWork;

		protected BaseService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public void Dispose()
		{
			_unitOfWork.Dispose();
		}
	}
}
