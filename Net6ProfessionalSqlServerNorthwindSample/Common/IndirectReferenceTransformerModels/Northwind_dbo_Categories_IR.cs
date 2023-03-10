/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Categories_IR
{
	public Northwind_dbo_Categories_IR() 
	{
	} 
	public Northwind_dbo_Categories_IR(
		String? categoryID_IR_,
		String? categoryName_,
		String? description_,
		Byte[]? picture_
	)
	{
		_categoryID_IR = categoryID_IR_;
		CategoryID_IR_OriginalValue = categoryID_IR_;
		_categoryName = categoryName_;
		CategoryName_OriginalValue = categoryName_;
		_description = description_;
		Description_OriginalValue = description_;
		_picture = picture_;
		Picture_OriginalValue = picture_;
		PrimaryKeyEncryptedForUpdateDeleteIdentification = categoryID_IR_;
	}
	[JsonConstructor]
	public Northwind_dbo_Categories_IR(
		String? CategoryID_IR,
		String? CategoryID_IR_OriginalValue,
		Boolean CategoryID_IR_HasBeenChanged,
		String CategoryName,
		String CategoryName_OriginalValue,
		Boolean CategoryName_HasBeenChanged,
		String? Description,
		String? Description_OriginalValue,
		Boolean Description_HasBeenChanged,
		Byte[]? Picture,
		Byte[]? Picture_OriginalValue,
		Boolean Picture_HasBeenChanged,
		String? PrimaryKeyEncryptedForUpdateDeleteIdentification,
		String? PrimaryKeyHashedForUniqueObjectComparison
	)
	{
		this.CategoryID_IR = CategoryID_IR;
		this.CategoryID_IR_OriginalValue = CategoryID_IR_OriginalValue;
		this.CategoryID_IR_HasBeenChanged = CategoryID_IR_HasBeenChanged;
		this.CategoryName = CategoryName;
		this.CategoryName_OriginalValue = CategoryName_OriginalValue;
		this.CategoryName_HasBeenChanged = CategoryName_HasBeenChanged;
		this.Description = Description;
		this.Description_OriginalValue = Description_OriginalValue;
		this.Description_HasBeenChanged = Description_HasBeenChanged;
		this.Picture = Picture;
		this.Picture_OriginalValue = Picture_OriginalValue;
		this.Picture_HasBeenChanged = Picture_HasBeenChanged;
		this.PrimaryKeyEncryptedForUpdateDeleteIdentification = PrimaryKeyEncryptedForUpdateDeleteIdentification;
		this.PrimaryKeyHashedForUniqueObjectComparison = PrimaryKeyHashedForUniqueObjectComparison;
	}
	/// <summary>
	/// SQL Column Description: Primary key encrypted value for update and delete identification purposes
	/// </summary>
	public String? PrimaryKeyEncryptedForUpdateDeleteIdentification { get; set; }
	/// <summary>
	/// SQL Column Description: Primary key hashed value for uniue object comparison purposes
	/// </summary>
	public String? PrimaryKeyHashedForUniqueObjectComparison { get; set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CategoryID_IR
	{
		get => _categoryID_IR;
		set
		{
			_categoryID_IR = value;
			CategoryID_IR_HasBeenChanged = _categoryID_IR == CategoryID_IR_OriginalValue ? false : true;
		}
	}
	private String? _categoryID_IR;
	public String? CategoryID_IR_OriginalValue { get; private set; }
	public Boolean CategoryID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CategoryName
	{
		get => _categoryName;
		set
		{
			_categoryName = value;
			CategoryName_HasBeenChanged = _categoryName == CategoryName_OriginalValue ? false : true;
		}
	}
	private String? _categoryName;
	public String? CategoryName_OriginalValue  { get; private set; }
	public Boolean CategoryName_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? Description
	{
		get => _description;
		set
		{
			_description = value;
			Description_HasBeenChanged = _description == Description_OriginalValue ? false : true;
		}
	}
	private String? _description;
	public String? Description_OriginalValue  { get; private set; }
	public Boolean Description_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Byte[]? Picture
	{
		get => _picture;
		set
		{
			_picture = value;
			Picture_HasBeenChanged = _picture == Picture_OriginalValue ? false : true;
		}
	}
	private Byte[]? _picture;
	public Byte[]? Picture_OriginalValue  { get; private set; }
	public Boolean Picture_HasBeenChanged  { get; private set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_Products_IR>?FK_Products_Categories_RefBy_IR { get; set; } = new HashSet<Northwind_dbo_Products_IR>();
}
