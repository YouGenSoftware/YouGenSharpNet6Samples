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
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class Northwind_HydratedStaticIndirectReferenceTransformerModels : Northwind_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public Northwind_dbo_Employees_IR GetHydratedStaticNorthwind_dbo_Employees_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Employees_IR();
		retObj.EmployeeID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.LastName = "PRPIipOhrMjO h9PQHKB";
		retObj.FirstName = "DFo5rBFl4S";
		retObj.Title = "tbOJqho4wIM4CSfmBzlgSQxGdJoHGU";
		retObj.TitleOfCourtesy = "gfqLo6WZbPwgaA3okecVqM3Lv";
		retObj.BirthDate = DateTime.Parse("6/26/2004 12:00:00 AM");
		retObj.HireDate = DateTime.Parse("1/27/2002 12:00:00 AM");
		retObj.Address = "ySJqdkUm2HCRpwtDRN egCOridUuzuBQ8JKFyI0IU8dAcRr7jkCE5yAnM1eS";
		retObj.City = "QttMmTVlHg0vLf5";
		retObj.Region = "15ELnOLubyd3gcO";
		retObj.PostalCode = " UrgPtyiOF";
		retObj.Country = "Vz37kbBRh8sQmfm";
		retObj.HomePhone = "uIb1gjcFTsv8x489PWO5eFYS";
		retObj.Extension = "o9Lm";
		retObj.Photo = new Byte[] { 4, 12, 244, 7, 96, 233, 11, 153, 5, 112, 135, 107, 65, 8, 178, 125, 187, 228, 81, 241, 177, 179, 35, 148, 174, 161, 95, 100, 48, 40, 67, 27, 13, 129, 49, 95, 251, 246, 97, 183, 15, 202, 115, 94, 225, 213, 142, 232, 165, 27, 92, 231, 31, 12, 10, 71, 201, 212, 204, 142, 168, 47, 87, 118, 107, 104, 80, 209, 24, 192, 229, 139, 51, 143, 83, 147, 82, 106, 133, 154, 215, 96, 206, 165, 51, 200, 39, 210, 20, 167, 132, 244, 217, 100, 227, 70, 38, 55, 132, 248 };
		retObj.Notes = "u2lszMKJpB310 jyeac9WrTUKBxlMNthmLu4h 3Nz54aZytG0yIxd6uQLZw0PyxdeF4syRuvopw0HYtlVacNBeKmhbADjK1mWzQw";
		retObj.ReportsTo_IR = _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1));
		retObj.PhotoPath = "5xi16XbkQHA iwjaV1CAcfd2 YhumFKUDzKvID3GuJKK0j15wliERafLZA5I bkPXMYGhCUCWgeJNkxdckdxijyzPyoq9FfR7VgtQe kq27HRtGAu6q3W3wxhZHRJvO8sdSuKZofIpVtT4VutPQtfEeRUxTz42yPxX0hF1B8yKvWwz6u7R0cp7jXKkmlETB43VN 8aI8C4Cpyvr3sSNufjeIjP5E9kRFcxq9SAEzrhtDBUMTvFs0DHu4mITrtlF";
		// Foreign key entities
		retObj.FK_Employees_Employees_Ref_IR = GetHydratedStaticNorthwind_dbo_Employees_IR();
		return retObj;
	}
}
