/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Dapper;
using Dapper.Oracle;
using System.Data;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories; 
public class XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Repository : IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Repository
{
	private readonly ILogger<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Repository> _logger;
	private readonly IDbConnection _dbConnection;
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Repository
	(
		ILogger<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Repository> logger
		,IDbConnection dbConnection
	)
	{
		_logger = logger;
		_dbConnection = dbConnection;
	}
	public async Task<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM?> Call_XE_HR_PACKAGE1_OPEN_TWO_CURSORS()
	{
		var retData = new XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM();
		using (IDbConnection cnn = _dbConnection)
		{
			var dynamicParameters = new OracleDynamicParameters();
			// Input parameters
			// Input output parameters
			// Output parameters
			// Output cursors
			dynamicParameters.Add("@EMPCURSOR", null, OracleMappingType.RefCursor, ParameterDirection.Output);
			dynamicParameters.Add("@DEPTCURSOR", null, OracleMappingType.RefCursor, ParameterDirection.Output);
			// Query
			using (var multi = await cnn.QueryMultipleAsync("[HR].[PACKAGE1].[OPEN_TWO_CURSORS]", dynamicParameters, commandType: CommandType.StoredProcedure))
			if (multi != null)
			{
				// Output cursor mappings
				retData.Query1_Results = await multi.ReadAsync<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query1>();
				retData.Query2_Results = await multi.ReadAsync<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2>();
			}
			// Input output mappings
			// Output mappings
		}
		return retData;
	}
	}