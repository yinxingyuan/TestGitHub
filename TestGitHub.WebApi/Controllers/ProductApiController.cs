using System;
using System.Web.Http;
using System.Collections.Generic;
using TestGitHub.Entities;
using TestGitHub.Services.Interfaces;
using TestGitHub.WebApi.Models;

namespace TestGitHub.WebApi.Controllers
{
	public class ProductApiController : CommonApiController<Product, IProductService>
	{


	}
}
