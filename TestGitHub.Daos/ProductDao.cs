using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using TestGitHub.Daos.Interfaces;
using TestGitHub.Entities;

namespace TestGitHub.Daos
{
	public class ProductDao : CommonObjectDao<Product>, IProductDao
	{
		public class ProductSqlBuilder : ObjectSqlBuilder
		{
			public ProductSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Product")
			{
				this.SqlInsert = "INSERT INTO Product (Number," + this.SqlBaseFieldInsertFront + ") VALUES (@Number," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Product SET Number=@Number," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class ProductResultHandler : CommonObjectResultHandler<Product>
		{
			public override void GetColumnValues(IDataReader reader, Product item)
			{
				base.GetColumnValues(reader, item);
				int ordinalNumber = reader.GetOrdinal("Number");
				item.Number = reader.IsDBNull(ordinalNumber) ? null : reader.GetString(ordinalNumber);
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Product item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Number", item.Number ?? (object) DBNull.Value);
			}
		}

		public ProductDao(SqlDialect sqlDialect) : base(new ProductSqlBuilder(sqlDialect), new ProductResultHandler())
		{
		}

		public ProductDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ProductSqlBuilder(sqlDialect), new ProductResultHandler(), schemaConnectionString)
		{
		}
	}
}
