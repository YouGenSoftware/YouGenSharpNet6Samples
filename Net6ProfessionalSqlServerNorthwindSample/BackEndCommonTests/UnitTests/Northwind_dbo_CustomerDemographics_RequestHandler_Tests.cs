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
public class Northwind_dbo_CustomerDemographics_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<Northwind_dbo_CustomerDemographics_RequestHandler>>? _logger;
	private Boolean isSecondaryLookup;
	private Northwind_HydratedDynamicEntities? _dynamicEntities;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<INorthwind_dbo_CustomerDemographics_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private Northwind_dbo_CustomerDemographics_IR_FluentValidator_Create? _createValidator;
	private Northwind_dbo_CustomerDemographics_IR_FluentValidator_Read? _readValidator;
	private Northwind_dbo_CustomerDemographics_IR_FluentValidator_Update? _updateValidator;
	private Northwind_dbo_CustomerDemographics_IR_FluentValidator_Delete? _deleteValidator;
	private INorthwind_dbo_CustomerDemographics_RequestHandler? _dynamicRequestHandler;
	private Northwind_HydratedStaticEntities? _staticEntities;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<INorthwind_dbo_CustomerDemographics_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private INorthwind_dbo_CustomerDemographics_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<Northwind_dbo_CustomerDemographics_RequestHandler>>();		
		isSecondaryLookup = false;
		_dynamicEntities = new Northwind_HydratedDynamicEntities();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_CustomerDemographics>(), isSecondaryLookup)).Returns(_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_CustomerDemographics_IR>(), isSecondaryLookup)).Returns(_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics());
		_createValidator = new Northwind_dbo_CustomerDemographics_IR_FluentValidator_Create();
		_readValidator = new Northwind_dbo_CustomerDemographics_IR_FluentValidator_Read();
		_updateValidator = new Northwind_dbo_CustomerDemographics_IR_FluentValidator_Update();
		_deleteValidator = new Northwind_dbo_CustomerDemographics_IR_FluentValidator_Delete();
		_dynamicRepository = new Mock<INorthwind_dbo_CustomerDemographics_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_CustomerDemographics>?)new List<Northwind_dbo_CustomerDemographics>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics()}));
		_staticEntities = new Northwind_HydratedStaticEntities();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_CustomerDemographics>(), isSecondaryLookup)).Returns(_staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerDemographics_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_CustomerDemographics_IR>(), isSecondaryLookup)).Returns(_staticEntities!.GetHydratedStaticNorthwind_dbo_CustomerDemographics());
		_staticRepository = new Mock<INorthwind_dbo_CustomerDemographics_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_CustomerDemographics>?)new List<Northwind_dbo_CustomerDemographics>{_staticEntities!.GetHydratedStaticNorthwind_dbo_CustomerDemographics()}));
		_dynamicRepository!.Setup(x => x.GetByCustomerTypeID(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_CustomerDemographics>?)new List<Northwind_dbo_CustomerDemographics>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics()}));
		_staticRepository!.Setup(x => x.GetByCustomerTypeID(It.IsAny<String>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_CustomerDemographics>?)new List<Northwind_dbo_CustomerDemographics>{_staticEntities!.GetHydratedStaticNorthwind_dbo_CustomerDemographics()}));
		_dynamicRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_CustomerDemographics>())).Returns(Task.FromResult((Northwind_dbo_CustomerDemographics?)_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics()));
		_staticRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_CustomerDemographics>())).Returns(Task.FromResult((Northwind_dbo_CustomerDemographics?)_staticEntities!.GetHydratedStaticNorthwind_dbo_CustomerDemographics()));
		_dynamicRepository!.Setup(x => x.UpdateByCustomerTypeID(It.IsAny<String>(), It.IsAny<Northwind_dbo_CustomerDemographics>()));
		_staticRepository!.Setup(x => x.UpdateByCustomerTypeID(It.IsAny<String>(), It.IsAny<Northwind_dbo_CustomerDemographics>()));
		_dynamicRepository!.Setup(x => x.DeleteByCustomerTypeID(It.IsAny<String>()));
		_staticRepository!.Setup(x => x.DeleteByCustomerTypeID(It.IsAny<String>()));
		_dynamicRequestHandler = new Northwind_dbo_CustomerDemographics_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
		_staticRequestHandler = new Northwind_dbo_CustomerDemographics_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics_IR();
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
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerDemographics_IR();
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
	public async Task GetByCustomerTypeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByCustomerTypeID(input.CustomerTypeID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerTypeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerDemographics_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByCustomerTypeID(input.CustomerTypeID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerTypeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByCustomerTypeID(input.CustomerTypeID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByCustomerTypeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerDemographics_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByCustomerTypeID(input.CustomerTypeID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerTypeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerDemographics_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByCustomerTypeID(input.CustomerTypeID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerTypeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerDemographics_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByCustomerTypeID(input.CustomerTypeID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
