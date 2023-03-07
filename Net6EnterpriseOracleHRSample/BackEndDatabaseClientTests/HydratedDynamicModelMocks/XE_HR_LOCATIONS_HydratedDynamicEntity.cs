/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class XE_HR_HydratedDynamicEntities  : XE_HR_HydratedDynamicEntitiesBase
{
	protected Filler<XE_HR_LOCATIONS> _XE_HR_LOCATIONS_Filler = new Filler<XE_HR_LOCATIONS>();
	protected FillerSetup? _XE_HR_LOCATIONS_FillerSetup;
	public FillerSetup GetXE_HR_LOCATIONS_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_XE_HR_LOCATIONS_FillerSetup != null)
			return _XE_HR_LOCATIONS_FillerSetup;
		_XE_HR_LOCATIONS_FillerSetup = _XE_HR_LOCATIONS_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.LOCATION_ID).Use(() => (fillPrimaryKey ? Convert.ToInt32(1) : 0))
		.OnProperty(x => x.STREET_ADDRESS).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.POSTAL_CODE).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(12)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.CITY).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(30)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.STATE_PROVINCE).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.COUNTRY_ID).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(2)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		// Foreign key entities
		.OnProperty(x => x.LOC_C_ID_FK_Ref).IgnoreIt()
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.DEPT_LOC_FK_RefBy).IgnoreIt()
		.Result;
		return _XE_HR_LOCATIONS_FillerSetup;
	}
	public XE_HR_LOCATIONS GetHydratedDynamicXE_HR_LOCATIONS(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_LOCATIONS(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<XE_HR_LOCATIONS> GetHydratedDynamicIEnumerableOfXE_HR_LOCATIONS(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_XE_HR_LOCATIONS_Filler.Setup(GetXE_HR_LOCATIONS_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _XE_HR_LOCATIONS_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<XE_HR_LOCATIONS> entities)
	{
		foreach (var entity in entities)
		{
			entity.LOC_C_ID_FK_Ref = GetHydratedDynamicXE_HR_COUNTRIES();
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<XE_HR_LOCATIONS> entities)
	{
		foreach (var entity in entities)
		{
			// entity.DEPT_LOC_FK_RefBy!.Add(GetHydratedDynamicXE_HR_DEPARTMENTS());
		}
	}
}