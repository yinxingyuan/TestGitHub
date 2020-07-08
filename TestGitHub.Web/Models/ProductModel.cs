using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TestGitHub.Entities;

namespace TestGitHub.Web.Models
{
	public class ProductModel: CommonModel<Product>
	{
		public string Number {get; set;}

		public override void PopulateFrom(Product entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Number = entity.Number;
		}

		public override void PopulateTo(Product entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Number = this.Number;

		}
	}
}
