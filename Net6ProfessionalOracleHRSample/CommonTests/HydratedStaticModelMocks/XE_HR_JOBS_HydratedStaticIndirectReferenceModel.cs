/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.Services;
namespace XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class XE_HR_HydratedStaticIndirectReferenceTransformerModels : XE_HR_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public XE_HR_JOBS_IR GetHydratedStaticXE_HR_JOBS_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_JOBS_IR();
		retObj.JOB_ID = (fillPrimaryKey ? "4NWhPI1gHp" : String.Empty);
		retObj.JOB_TITLE = "tVkbJ12RRrDuQGgk9p35194XDU5APqVOm1b";
		retObj.MIN_SALARY = (130665025);
		retObj.MAX_SALARY = (1576686058);
		return retObj;
	}
}
