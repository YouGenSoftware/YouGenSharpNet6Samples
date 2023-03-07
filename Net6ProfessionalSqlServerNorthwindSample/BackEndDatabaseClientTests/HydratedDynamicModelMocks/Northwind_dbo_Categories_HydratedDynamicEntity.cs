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
	protected Filler<Northwind_dbo_Categories> _Northwind_dbo_Categories_Filler = new Filler<Northwind_dbo_Categories>();
	protected FillerSetup? _Northwind_dbo_Categories_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Categories_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_Northwind_dbo_Categories_FillerSetup != null)
			return _Northwind_dbo_Categories_FillerSetup;
		_Northwind_dbo_Categories_FillerSetup = _Northwind_dbo_Categories_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.CategoryID).Use(() => (fillPrimaryKey ? Convert.ToInt32(1) : 0))
		.OnProperty(x => x.CategoryName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Description).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(100)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Picture).Use(() => {
                    var bytes = new Byte[Convert.ToInt32(100)];
                    Random.Shared.NextBytes(bytes);
                    return bytes;
                })
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.FK_Products_Categories_RefBy).IgnoreIt()
		.Result;
		return _Northwind_dbo_Categories_FillerSetup;
	}
	public Northwind_dbo_Categories GetHydratedDynamicNorthwind_dbo_Categories(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Categories(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<Northwind_dbo_Categories> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Categories(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_Northwind_dbo_Categories_Filler.Setup(GetNorthwind_dbo_Categories_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _Northwind_dbo_Categories_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<Northwind_dbo_Categories> entities)
	{
		foreach (var entity in entities)
		{
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<Northwind_dbo_Categories> entities)
	{
		foreach (var entity in entities)
		{
			// entity.FK_Products_Categories_RefBy!.Add(GetHydratedDynamicNorthwind_dbo_Products());
		}
	}
}