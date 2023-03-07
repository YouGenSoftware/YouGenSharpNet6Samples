/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
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
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_Common.Validators;
using XE_HR_BackEndCommon.IndirectReferenceTransformers;
using XE_HR_BackEndCommon.RequestHandlers;
using XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
using XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
using XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
using XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommonTests.RequestHandlerUnitTests;
[TestClass()]
public class XE_HR_REGIONS_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<XE_HR_REGIONS_RequestHandler>>? _logger;
	private Boolean isSecondaryLookup;
	private XE_HR_HydratedDynamicEntities? _dynamicEntities;
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<IXE_HR_REGIONS_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private XE_HR_REGIONS_IR_FluentValidator_Create? _createValidator;
	private XE_HR_REGIONS_IR_FluentValidator_Read? _readValidator;
	private XE_HR_REGIONS_IR_FluentValidator_Update? _updateValidator;
	private XE_HR_REGIONS_IR_FluentValidator_Delete? _deleteValidator;
	private IXE_HR_REGIONS_RequestHandler? _dynamicRequestHandler;
	private XE_HR_HydratedStaticEntities? _staticEntities;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<IXE_HR_REGIONS_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private IXE_HR_REGIONS_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<XE_HR_REGIONS_RequestHandler>>();		
		isSecondaryLookup = false;
		_dynamicEntities = new XE_HR_HydratedDynamicEntities();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_REGIONS>(), isSecondaryLookup)).Returns(_dynamicIRModels!.GetHydratedDynamicXE_HR_REGIONS_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_REGIONS_IR>(), isSecondaryLookup)).Returns(_dynamicEntities!.GetHydratedDynamicXE_HR_REGIONS());
		_createValidator = new XE_HR_REGIONS_IR_FluentValidator_Create();
		_readValidator = new XE_HR_REGIONS_IR_FluentValidator_Read();
		_updateValidator = new XE_HR_REGIONS_IR_FluentValidator_Update();
		_deleteValidator = new XE_HR_REGIONS_IR_FluentValidator_Delete();
		_dynamicRepository = new Mock<IXE_HR_REGIONS_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<XE_HR_REGIONS>?)new List<XE_HR_REGIONS>{_dynamicEntities!.GetHydratedDynamicXE_HR_REGIONS()}));
		_staticEntities = new XE_HR_HydratedStaticEntities();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<XE_HR_REGIONS>(), isSecondaryLookup)).Returns(_staticIRModels!.GetHydratedStaticXE_HR_REGIONS_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<XE_HR_REGIONS_IR>(), isSecondaryLookup)).Returns(_staticEntities!.GetHydratedStaticXE_HR_REGIONS());
		_staticRepository = new Mock<IXE_HR_REGIONS_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<XE_HR_REGIONS>?)new List<XE_HR_REGIONS>{_staticEntities!.GetHydratedStaticXE_HR_REGIONS()}));
		_dynamicRepository!.Setup(x => x.GetByREGION_ID(It.IsAny<Int32>())).Returns(Task.FromResult((IEnumerable<XE_HR_REGIONS>?)new List<XE_HR_REGIONS>{_dynamicEntities!.GetHydratedDynamicXE_HR_REGIONS()}));
		_staticRepository!.Setup(x => x.GetByREGION_ID(It.IsAny<Int32>())).Returns(Task.FromResult((IEnumerable<XE_HR_REGIONS>?)new List<XE_HR_REGIONS>{_staticEntities!.GetHydratedStaticXE_HR_REGIONS()}));
		_dynamicRepository!.Setup(x => x.Create(It.IsAny<XE_HR_REGIONS>())).Returns(Task.FromResult((XE_HR_REGIONS?)_dynamicEntities!.GetHydratedDynamicXE_HR_REGIONS()));
		_staticRepository!.Setup(x => x.Create(It.IsAny<XE_HR_REGIONS>())).Returns(Task.FromResult((XE_HR_REGIONS?)_staticEntities!.GetHydratedStaticXE_HR_REGIONS()));
		_dynamicRepository!.Setup(x => x.UpdateByREGION_ID(It.IsAny<Int32>(), It.IsAny<XE_HR_REGIONS>()));
		_staticRepository!.Setup(x => x.UpdateByREGION_ID(It.IsAny<Int32>(), It.IsAny<XE_HR_REGIONS>()));
		_dynamicRepository!.Setup(x => x.DeleteByREGION_ID(It.IsAny<Int32>()));
		_staticRepository!.Setup(x => x.DeleteByREGION_ID(It.IsAny<Int32>()));
		_dynamicRequestHandler = new XE_HR_REGIONS_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
		_staticRequestHandler = new XE_HR_REGIONS_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_REGIONS_IR();
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
		var input = _staticIRModels!.GetHydratedStaticXE_HR_REGIONS_IR();
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
	public async Task GetByREGION_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_REGIONS_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByREGION_ID(input.REGION_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByREGION_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_REGIONS_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByREGION_ID(input.REGION_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByREGION_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_REGIONS_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_REGIONS_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByREGION_ID(input.REGION_ID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByREGION_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_REGIONS_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByREGION_ID(input.REGION_ID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByREGION_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_REGIONS_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByREGION_ID(input.REGION_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByREGION_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_REGIONS_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByREGION_ID(input.REGION_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}