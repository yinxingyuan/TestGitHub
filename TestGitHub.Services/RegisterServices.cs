﻿using MetaShare.Common.Core.CommonService;
using TestGitHub.Services.Interfaces;

namespace TestGitHub.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IProductService), new ProductService(), isRegister);
		}
	}
}
