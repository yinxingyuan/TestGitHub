using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using TestGitHub.Entities;
using MetaShare.Common.Core.Services;
using TestGitHub.Daos.Interfaces;
using TestGitHub.Services.Interfaces;


namespace TestGitHub.Services
{
	public class ProductService : Service<Product>, IProductService
	{
		public ProductService() : base(typeof (IProductDao))
		{
		}

	}
}
