/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
namespace Northwind_BackEndCommon.Services;
public interface IEncryptionDecryptionService
{
    Byte DecByte(String? input);
    Byte? DecByteNullable(String? input);
    Decimal DecDecimal(String? input);
    Decimal? DecDecimalNullable(String? input);
    Double DecDouble(String? input);
    Double? DecDoubleNullable(String? input);
    Int16 DecInt16(String? input);
    Int16? DecInt16Nullable(String? input);
    Int32 DecInt32(String? input);
    Int32? DecInt32Nullable(String? input);
    Int64 DecInt64(String? input);
    Int64? DecInt64Nullable(String? input);
    Single DecSingle(String? input);
    Single? DecSingleNullable(String? input);
    String? DecStr(String? input);
    UInt16 DecUInt16(String? input);
    UInt16? DecUInt16Nullable(String? input);
    UInt32 DecUInt32(String? input);
    UInt32? DecUInt32Nullable(String? input);
    UInt64 DecUInt64(String? input);
    UInt64? DecUInt64Nullable(String? input);
    String? EncByte(Byte input);
    String? EncByteNullable(Byte? input);
    String? EncDecimal(Decimal input);
    String? EncDecimalNullable(Decimal? input);
    String? EncDouble(Double input);
    String? EncDoubleNullable(Double? input);
    String? EncInt16(Int16 input);
    String? EncInt16Nullable(Int16? input);
    String? EncInt32(Int32 input);
    String? EncInt32Nullable(Int32? input);
    String? EncInt64(Int64 input);
    String? EncInt64Nullable(Int64? input);
    String? EncSingle(Single input);
    String? EncSingleNullable(Single? input);
    String? EncStr(String? input);
    String? EncUInt16(UInt16 input);
    String? EncUInt16Nullable(UInt16? input);
    String? EncUInt32(UInt32 input);
    String? EncUInt32Nullable(UInt32? input);
    String? EncUInt64(UInt64 input);
    String? EncUInt64Nullable(UInt64? input);
    String? CreateHash(String? input);
}
