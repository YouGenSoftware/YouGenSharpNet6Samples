/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class Northwind_HydratedDynamicEntities  : Northwind_HydratedDynamicEntitiesBase
{
	protected Filler<Northwind_dbo_Products> _Northwind_dbo_Products_Filler = new Filler<Northwind_dbo_Products>();
	protected FillerSetup? _Northwind_dbo_Products_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Products_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_Northwind_dbo_Products_FillerSetup != null)
			return _Northwind_dbo_Products_FillerSetup;
		_Northwind_dbo_Products_FillerSetup = _Northwind_dbo_Products_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.ProductID).Use(() => (fillPrimaryKey ? Convert.ToInt32(1) : 0))
		.OnProperty(x => x.ProductName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.SupplierID).Use(() => Convert.ToInt32(1))
		.OnProperty(x => x.CategoryID).Use(() => Convert.ToInt32(1))
		.OnProperty(x => x.QuantityPerUnit).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(20)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.UnitPrice).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.UnitsInStock).Use(() => Convert.ToInt16(Random.Shared.Next(Int16.MinValue, Int16.MaxValue)))
		.OnProperty(x => x.UnitsOnOrder).Use(() => Convert.ToInt16(Random.Shared.Next(Int16.MinValue, Int16.MaxValue)))
		.OnProperty(x => x.ReorderLevel).Use(() => Convert.ToInt16(Random.Shared.Next(Int16.MinValue, Int16.MaxValue)))
		.OnProperty(x => x.Discontinued).Use(() => (Random.Shared.Next() > (Int32.MaxValue / 2)))
		// Foreign key entities
		.OnProperty(x => x.FK_Products_Categories_Ref).IgnoreIt()
		.OnProperty(x => x.FK_Products_Suppliers_Ref).IgnoreIt()
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.FK_Order_Details_Products_RefBy).IgnoreIt()
		.Result;
		return _Northwind_dbo_Products_FillerSetup;
	}
	public Northwind_dbo_Products GetHydratedDynamicNorthwind_dbo_Products(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Products(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<Northwind_dbo_Products> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Products(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_Northwind_dbo_Products_Filler.Setup(GetNorthwind_dbo_Products_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _Northwind_dbo_Products_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<Northwind_dbo_Products> entities)
	{
		foreach (var entity in entities)
		{
			entity.FK_Products_Categories_Ref = GetHydratedDynamicNorthwind_dbo_Categories();
			entity.FK_Products_Suppliers_Ref = GetHydratedDynamicNorthwind_dbo_Suppliers();
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<Northwind_dbo_Products> entities)
	{
		foreach (var entity in entities)
		{
			// entity.FK_Order_Details_Products_RefBy!.Add(GetHydratedDynamicNorthwind_dbo_Order_Details());
		}
	}
}
