using MetaShare.Common.Core.Daos;
using TestGitHub.Daos.Interfaces;

namespace TestGitHub.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(IProductDao), new ProductDaoMock(), isRegister);
		}
	}
}
