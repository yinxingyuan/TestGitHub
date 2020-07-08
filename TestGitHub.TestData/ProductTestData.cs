using System;
using System.Collections.Generic;
using NUnit.Framework;
using TestGitHub.Entities;

namespace TestGitHub.TestData
{
	public class ProductTestData
	{
		public const int ProductCount = 3;

		 public static List<Product> CreateProduct()
		{
			return new List<Product>
			{
				CreateProduct1(),
				CreateProduct2(),
				CreateProduct3(),
			};
		}

		 public static Product CreateProduct1()
		{
			return new Product
			{
					Id = 1, 
					Number = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		 public static Product CreateProduct2()
		{
			return new Product
			{
					Id = 2, 
					Number = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		 public static Product CreateProduct3()
		{
			return new Product
			{
					Id = 3, 
					Number = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		public static void AssertAreEqual(Product expected, Product actual)
		{
			Assert.AreEqual(expected.Number, actual.Number);
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.Name, actual.Name);
		}
	}
}
