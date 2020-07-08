using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;

/*add customized code between this region*/

/*add customized code between this region*/
namespace TestGitHub.Entities
{
	public class Product : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public string Number {get; set;}

	/*add customized code between this region*/
	
         [DataMember]
	 public DateTime CreateDate {get;set;}
	/*add customized code between this region*/
	}
}
