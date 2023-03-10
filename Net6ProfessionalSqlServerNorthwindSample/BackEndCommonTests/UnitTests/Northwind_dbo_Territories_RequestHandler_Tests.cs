/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_Common.Validators;
using Northwind_BackEndCommon.IndirectReferenceTransformers;
using Northwind_BackEndCommon.RequestHandlers;
using Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
using Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
namespace Northwind_BackEndCommonTests.RequestHandlerUnitTests;
[TestClass()]
public class Northwind_dbo_Territories_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<Northwind_dbo_Territories_RequestHandler>>? _logger;
	private Boolean isSecondaryLookup;
	private Northwind_HydratedDynamicEntities? _dynamicEntities;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<INorthwind_dbo_Territories_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private Northwind_dbo_Territories_IR_FluentValidator_Create? _createValidator;
	private Northwind_dbo_Territories_IR_FluentValidator_Read? _readValidator;
	private Northwind_dbo_Territories_IR_FluentValidator_Update? _updateValidator;
	private Northwind_dbo_Territories_IR_FluentValidator_Delete? _deleteValidator;
	private INorthwind_dbo_Territories_RequestHandler? _dynamicRequestHandler;
	private Northwind_HydratedStaticEntities? _staticEntities;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<INorthwind_dbo_Territories_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private INorthwind_dbo_Territories_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<Northwind_dbo_Territories_RequestHandler>>();		
		isSecondaryLookup = false;
		_dynamicEntities = new Northwind_HydratedDynamicEntities();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Territories>(), isSecondaryLookup)).Returns(_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Territories_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Territories_IR>(), isSecondaryLookup)).Returns(_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Territories());
		_createValidator = new Northwind_dbo_Territories_IR_FluentValidator_Create();
		_readValidator = new Northwind_dbo_Territories_IR_FluentValidator_Read();
		_updateValidator = new Northwind_dbo_Territories_IR_FluentValidator_Update();
		_deleteValidator = new Northwind_dbo_Territories_IR_FluentValidator_Delete();
		_dynamicRepository = new Mock<INorthwind_dbo_Territories_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Territories>?)new List<Northwind_dbo_Territories>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Territories()}));
		_staticEntities = new Northwind_HydratedStaticEntities();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Territories>(), isSecondaryLookup)).Returns(_staticIRModels!.GetHydratedStaticNorthwind_dbo_Territories_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Territories_IR>(), isSecondaryLookup)).Returns(_staticEntities!.GetHydratedStaticNorthwind_dbo_Territories());
		_staticRepository = new Mock<INorthwind_dbo_Territories_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Territories>?)new List<Northwind_dbo_Territories>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Territories()}));
		_dynamicRepository!.Setup(x => x.GetByTerritoryID(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Territories>?)new List<Northwind_dbo_Territories>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Territories()}));
		_staticRepository!.Setup(x => x.GetByTerritoryID(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Territories>?)new List<Northwind_dbo_Territories>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Territories()}));
		_dynamicRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_Territories>())).Returns(Task.FromResult((Northwind_dbo_Territories?)_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Territories()));
		_staticRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_Territories>())).Returns(Task.FromResult((Northwind_dbo_Territories?)_staticEntities!.GetHydratedStaticNorthwind_dbo_Territories()));
		_dynamicRepository!.Setup(x => x.UpdateByTerritoryID(It.IsAny<String>(), It.IsAny<Northwind_dbo_Territories>()));
		_staticRepository!.Setup(x => x.UpdateByTerritoryID(It.IsAny<String>(), It.IsAny<Northwind_dbo_Territories>()));
		_dynamicRepository!.Setup(x => x.DeleteByTerritoryID(It.IsAny<String>()));
		_staticRepository!.Setup(x => x.DeleteByTerritoryID(It.IsAny<String>()));
		_dynamicRequestHandler = new Northwind_dbo_Territories_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
		_staticRequestHandler = new Northwind_dbo_Territories_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Territories_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleCreate(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetAllDynamicTest()
	{
		// When
		var retData = await _dynamicRequestHandler!.HandleGetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Territories_IR();
		// When
		var retData = await _staticRequestHandler!.HandleCreate(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetAllStaticTest()
	{
		// When
		var retData = await _staticRequestHandler!.HandleGetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByTerritoryIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Territories_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByTerritoryID(input.TerritoryID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByTerritoryIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Territories_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByTerritoryID(input.TerritoryID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByTerritoryIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Territories_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Territories_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByTerritoryID(input.TerritoryID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByTerritoryIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Territories_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByTerritoryID(input.TerritoryID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByTerritoryIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Territories_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByTerritoryID(input.TerritoryID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByTerritoryIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Territories_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByTerritoryID(input.TerritoryID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
