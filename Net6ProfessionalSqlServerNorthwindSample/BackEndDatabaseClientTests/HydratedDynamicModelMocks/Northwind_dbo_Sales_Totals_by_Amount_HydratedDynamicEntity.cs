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
	protected Filler<Northwind_dbo_Sales_Totals_by_Amount> _Northwind_dbo_Sales_Totals_by_Amount_Filler = new Filler<Northwind_dbo_Sales_Totals_by_Amount>();
	protected FillerSetup? _Northwind_dbo_Sales_Totals_by_Amount_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Sales_Totals_by_Amount_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_Northwind_dbo_Sales_Totals_by_Amount_FillerSetup != null)
			return _Northwind_dbo_Sales_Totals_by_Amount_FillerSetup;
		_Northwind_dbo_Sales_Totals_by_Amount_FillerSetup = _Northwind_dbo_Sales_Totals_by_Amount_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.SaleAmount).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.OrderID).Use(() => Random.Shared.Next(Int32.MinValue, Int32.MaxValue))
		.OnProperty(x => x.CompanyName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ShippedDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.Result;
		return _Northwind_dbo_Sales_Totals_by_Amount_FillerSetup;
	}
	public Northwind_dbo_Sales_Totals_by_Amount GetHydratedDynamicNorthwind_dbo_Sales_Totals_by_Amount(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Sales_Totals_by_Amount(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<Northwind_dbo_Sales_Totals_by_Amount> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Sales_Totals_by_Amount(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_Northwind_dbo_Sales_Totals_by_Amount_Filler.Setup(GetNorthwind_dbo_Sales_Totals_by_Amount_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects = _Northwind_dbo_Sales_Totals_by_Amount_Filler.Create(numberToCreate);
		return retObjects;
	}
}
