/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class XE_HR_HydratedStaticEntities 
{
	public XE_HR_LOCATIONS GetHydratedStaticXE_HR_LOCATIONS(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_LOCATIONS();
		retObj.LOCATION_ID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.STREET_ADDRESS = "R Q5oD2cDDLEAs0beix2GXFhFjXwsMcuNEUFCPQR";
		retObj.POSTAL_CODE = "a0dy9G9GNK10";
		retObj.CITY = "JcQpww5BmOYU39dQ0aq5tQTQTP jEX";
		retObj.STATE_PROVINCE = "tkSehE4fRIH7h4xUJOCUkaLNR";
		retObj.COUNTRY_ID = "zM";
		// Foreign key entities
		retObj.LOC_C_ID_FK_Ref = GetHydratedStaticXE_HR_COUNTRIES();
		return retObj;
	}
}