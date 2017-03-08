using System;
using System.Collections.Generic;
using AutoMapper;
using Liss.Data;

namespace Liss.Domain.Services
{
	public class BaseService<TEntity> : IDisposable
	{
		private readonly IUnitOfWork _unitOfWork = null;

		protected IUnitOfWork UnitOfWork => _unitOfWork;

		protected BaseService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		#region IDisposable members

		public void Dispose()
		{
			_unitOfWork?.Dispose();
		}

		#endregion

		protected List<TEntity> CreateDomainEntitiesList<TDbEntity>(IMapper mapper, List<TDbEntity> dbEntitiesList)
		{
			return mapper.Map<List<TDbEntity> , List<TEntity>>(dbEntitiesList);
		}
	}
}
