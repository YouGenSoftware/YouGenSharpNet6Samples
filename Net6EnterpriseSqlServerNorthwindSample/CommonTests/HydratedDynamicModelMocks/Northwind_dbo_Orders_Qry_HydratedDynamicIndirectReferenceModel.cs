/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Tynamix.ObjectFiller;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
public partial class Northwind_HydratedDynamicIndirectReferenceTransformerModels : Northwind_HydratedDynamicIndirectReferenceTransformerModelsBase
{
	protected Filler<Northwind_dbo_Orders_Qry_IR> _Northwind_dbo_Orders_Qry_IR_Filler = new Filler<Northwind_dbo_Orders_Qry_IR>();
	protected FillerSetup? _Northwind_dbo_Orders_Qry_IR_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Orders_Qry_IR_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_Northwind_dbo_Orders_Qry_IR_FillerSetup != null)
			return _Northwind_dbo_Orders_Qry_IR_FillerSetup;
		_Northwind_dbo_Orders_Qry_IR_FillerSetup = _Northwind_dbo_Orders_Qry_IR_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.OrderID_IR).Use(() => _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)))
		.OnProperty(x => x.CustomerID).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(5)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.EmployeeID_IR).Use(() => _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1)))
		.OnProperty(x => x.OrderDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.RequiredDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.ShippedDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.ShipVia).Use(() => Random.Shared.Next(Int32.MinValue, Int32.MaxValue))
		.OnProperty(x => x.Freight).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.ShipName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipAddress).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(60)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipCity).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipRegion).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipPostalCode).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShipCountry).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.CompanyName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Address).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(60)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.City).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Region).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.PostalCode).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Country).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.Result;
		return _Northwind_dbo_Orders_Qry_IR_FillerSetup;
	}
	public Northwind_dbo_Orders_Qry_IR GetHydratedDynamicNorthwind_dbo_Orders_Qry_IR(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Orders_Qry_IR(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<Northwind_dbo_Orders_Qry_IR> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Orders_Qry_IR(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_Northwind_dbo_Orders_Qry_IR_Filler.Setup(GetNorthwind_dbo_Orders_Qry_IR_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects =  _Northwind_dbo_Orders_Qry_IR_Filler.Create(numberToCreate);
		return retObjects;
	}
}