using MetaShare.Common.Core.Daos;
using TestGitHub.Entities;
using TestGitHub.Daos.Interfaces;
using TestGitHub.TestData;

namespace TestGitHub.Daos.Mocks
{
	public class ProductDaoMock : MockDao<Product>, IProductDao
	{
		public ProductDaoMock() : base(ProductTestData.CreateProduct())
		{
		}
	}
}
