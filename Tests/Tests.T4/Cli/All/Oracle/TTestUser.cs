// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.Oracle
{
	[Table("t_test_user")]
	public class TTestUser : IEquatable<TTestUser>
	{
		[Column("user_id", DataType  = DataType.Decimal, DbType   = "NUMBER"        , Length = 22             , IsPrimaryKey = true)] public OracleDecimal UserId { get; set; } // NUMBER
		[Column("name"   , CanBeNull = false           , DataType = DataType.VarChar, DbType = "VARCHAR2(255)", Length       = 255 )] public string        Name   { get; set; } = null!; // VARCHAR2(255)

		#region IEquatable<T> support
		private static readonly IEqualityComparer<TTestUser> _equalityComparer = ComparerBuilder.GetEqualityComparer<TTestUser>(c => c.UserId);

		public bool Equals(TTestUser? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as TTestUser);
		}
		#endregion

		#region Associations
		/// <summary>
		/// SYS_C007192 backreference
		/// </summary>
		[Association(ThisKey = nameof(UserId), OtherKey = nameof(TTestUserContract.UserId))]
		public IEnumerable<TTestUserContract> TTestUserContracts { get; set; } = null!;
		#endregion
	}
}
