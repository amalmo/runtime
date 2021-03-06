// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.Arm
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["Abs.Vector64.Int16"] = Abs_Vector64_Int16,
                ["Abs.Vector64.Int32"] = Abs_Vector64_Int32,
                ["Abs.Vector64.SByte"] = Abs_Vector64_SByte,
                ["Abs.Vector64.Single"] = Abs_Vector64_Single,
                ["Abs.Vector128.Int16"] = Abs_Vector128_Int16,
                ["Abs.Vector128.Int32"] = Abs_Vector128_Int32,
                ["Abs.Vector128.SByte"] = Abs_Vector128_SByte,
                ["Abs.Vector128.Single"] = Abs_Vector128_Single,
                ["AbsScalar.Vector64.Double"] = AbsScalar_Vector64_Double,
                ["AbsScalar.Vector64.Single"] = AbsScalar_Vector64_Single,
                ["AbsoluteCompareGreaterThan.Vector64.Single"] = AbsoluteCompareGreaterThan_Vector64_Single,
                ["AbsoluteCompareGreaterThan.Vector128.Single"] = AbsoluteCompareGreaterThan_Vector128_Single,
                ["AbsoluteCompareGreaterThanOrEqual.Vector64.Single"] = AbsoluteCompareGreaterThanOrEqual_Vector64_Single,
                ["AbsoluteCompareGreaterThanOrEqual.Vector128.Single"] = AbsoluteCompareGreaterThanOrEqual_Vector128_Single,
                ["AbsoluteCompareLessThan.Vector64.Single"] = AbsoluteCompareLessThan_Vector64_Single,
                ["AbsoluteCompareLessThan.Vector128.Single"] = AbsoluteCompareLessThan_Vector128_Single,
                ["AbsoluteCompareLessThanOrEqual.Vector64.Single"] = AbsoluteCompareLessThanOrEqual_Vector64_Single,
                ["AbsoluteCompareLessThanOrEqual.Vector128.Single"] = AbsoluteCompareLessThanOrEqual_Vector128_Single,
                ["AbsoluteDifference.Vector64.Byte"] = AbsoluteDifference_Vector64_Byte,
                ["AbsoluteDifference.Vector64.Int16"] = AbsoluteDifference_Vector64_Int16,
                ["AbsoluteDifference.Vector64.Int32"] = AbsoluteDifference_Vector64_Int32,
                ["AbsoluteDifference.Vector64.SByte"] = AbsoluteDifference_Vector64_SByte,
                ["AbsoluteDifference.Vector64.Single"] = AbsoluteDifference_Vector64_Single,
                ["AbsoluteDifference.Vector64.UInt16"] = AbsoluteDifference_Vector64_UInt16,
                ["AbsoluteDifference.Vector64.UInt32"] = AbsoluteDifference_Vector64_UInt32,
                ["AbsoluteDifference.Vector128.Byte"] = AbsoluteDifference_Vector128_Byte,
                ["AbsoluteDifference.Vector128.Int16"] = AbsoluteDifference_Vector128_Int16,
                ["AbsoluteDifference.Vector128.Int32"] = AbsoluteDifference_Vector128_Int32,
                ["AbsoluteDifference.Vector128.SByte"] = AbsoluteDifference_Vector128_SByte,
                ["AbsoluteDifference.Vector128.Single"] = AbsoluteDifference_Vector128_Single,
                ["AbsoluteDifference.Vector128.UInt16"] = AbsoluteDifference_Vector128_UInt16,
                ["AbsoluteDifference.Vector128.UInt32"] = AbsoluteDifference_Vector128_UInt32,
                ["Add.Vector64.Byte"] = Add_Vector64_Byte,
                ["Add.Vector64.Int16"] = Add_Vector64_Int16,
                ["Add.Vector64.Int32"] = Add_Vector64_Int32,
                ["Add.Vector64.SByte"] = Add_Vector64_SByte,
                ["Add.Vector64.Single"] = Add_Vector64_Single,
                ["Add.Vector64.UInt16"] = Add_Vector64_UInt16,
                ["Add.Vector64.UInt32"] = Add_Vector64_UInt32,
                ["Add.Vector128.Byte"] = Add_Vector128_Byte,
                ["Add.Vector128.Int16"] = Add_Vector128_Int16,
                ["Add.Vector128.Int32"] = Add_Vector128_Int32,
                ["Add.Vector128.Int64"] = Add_Vector128_Int64,
                ["Add.Vector128.SByte"] = Add_Vector128_SByte,
                ["Add.Vector128.Single"] = Add_Vector128_Single,
                ["Add.Vector128.UInt16"] = Add_Vector128_UInt16,
                ["Add.Vector128.UInt32"] = Add_Vector128_UInt32,
                ["Add.Vector128.UInt64"] = Add_Vector128_UInt64,
                ["AddPairwise.Vector64.Byte"] = AddPairwise_Vector64_Byte,
                ["AddPairwise.Vector64.Int16"] = AddPairwise_Vector64_Int16,
                ["AddPairwise.Vector64.Int32"] = AddPairwise_Vector64_Int32,
                ["AddPairwise.Vector64.SByte"] = AddPairwise_Vector64_SByte,
                ["AddPairwise.Vector64.Single"] = AddPairwise_Vector64_Single,
                ["AddPairwise.Vector64.UInt16"] = AddPairwise_Vector64_UInt16,
                ["AddPairwise.Vector64.UInt32"] = AddPairwise_Vector64_UInt32,
                ["AddScalar.Vector64.Double"] = AddScalar_Vector64_Double,
                ["AddScalar.Vector64.Int64"] = AddScalar_Vector64_Int64,
                ["AddScalar.Vector64.Single"] = AddScalar_Vector64_Single,
                ["AddScalar.Vector64.UInt64"] = AddScalar_Vector64_UInt64,
                ["And.Vector64.Byte"] = And_Vector64_Byte,
                ["And.Vector64.Double"] = And_Vector64_Double,
                ["And.Vector64.Int16"] = And_Vector64_Int16,
                ["And.Vector64.Int32"] = And_Vector64_Int32,
                ["And.Vector64.Int64"] = And_Vector64_Int64,
                ["And.Vector64.SByte"] = And_Vector64_SByte,
                ["And.Vector64.Single"] = And_Vector64_Single,
                ["And.Vector64.UInt16"] = And_Vector64_UInt16,
                ["And.Vector64.UInt32"] = And_Vector64_UInt32,
                ["And.Vector64.UInt64"] = And_Vector64_UInt64,
                ["And.Vector128.Byte"] = And_Vector128_Byte,
                ["And.Vector128.Double"] = And_Vector128_Double,
                ["And.Vector128.Int16"] = And_Vector128_Int16,
                ["And.Vector128.Int32"] = And_Vector128_Int32,
                ["And.Vector128.Int64"] = And_Vector128_Int64,
                ["And.Vector128.SByte"] = And_Vector128_SByte,
                ["And.Vector128.Single"] = And_Vector128_Single,
                ["And.Vector128.UInt16"] = And_Vector128_UInt16,
                ["And.Vector128.UInt32"] = And_Vector128_UInt32,
                ["And.Vector128.UInt64"] = And_Vector128_UInt64,
                ["BitwiseClear.Vector64.Byte"] = BitwiseClear_Vector64_Byte,
                ["BitwiseClear.Vector64.Double"] = BitwiseClear_Vector64_Double,
                ["BitwiseClear.Vector64.Int16"] = BitwiseClear_Vector64_Int16,
                ["BitwiseClear.Vector64.Int32"] = BitwiseClear_Vector64_Int32,
                ["BitwiseClear.Vector64.Int64"] = BitwiseClear_Vector64_Int64,
                ["BitwiseClear.Vector64.SByte"] = BitwiseClear_Vector64_SByte,
                ["BitwiseClear.Vector64.Single"] = BitwiseClear_Vector64_Single,
                ["BitwiseClear.Vector64.UInt16"] = BitwiseClear_Vector64_UInt16,
                ["BitwiseClear.Vector64.UInt32"] = BitwiseClear_Vector64_UInt32,
                ["BitwiseClear.Vector64.UInt64"] = BitwiseClear_Vector64_UInt64,
                ["BitwiseClear.Vector128.Byte"] = BitwiseClear_Vector128_Byte,
                ["BitwiseClear.Vector128.Double"] = BitwiseClear_Vector128_Double,
                ["BitwiseClear.Vector128.Int16"] = BitwiseClear_Vector128_Int16,
                ["BitwiseClear.Vector128.Int32"] = BitwiseClear_Vector128_Int32,
                ["BitwiseClear.Vector128.Int64"] = BitwiseClear_Vector128_Int64,
                ["BitwiseClear.Vector128.SByte"] = BitwiseClear_Vector128_SByte,
                ["BitwiseClear.Vector128.Single"] = BitwiseClear_Vector128_Single,
                ["BitwiseClear.Vector128.UInt16"] = BitwiseClear_Vector128_UInt16,
                ["BitwiseClear.Vector128.UInt32"] = BitwiseClear_Vector128_UInt32,
                ["BitwiseClear.Vector128.UInt64"] = BitwiseClear_Vector128_UInt64,
                ["BitwiseSelect.Vector64.Byte"] = BitwiseSelect_Vector64_Byte,
                ["BitwiseSelect.Vector64.Double"] = BitwiseSelect_Vector64_Double,
                ["BitwiseSelect.Vector64.Int16"] = BitwiseSelect_Vector64_Int16,
                ["BitwiseSelect.Vector64.Int32"] = BitwiseSelect_Vector64_Int32,
                ["BitwiseSelect.Vector64.Int64"] = BitwiseSelect_Vector64_Int64,
                ["BitwiseSelect.Vector64.SByte"] = BitwiseSelect_Vector64_SByte,
                ["BitwiseSelect.Vector64.Single"] = BitwiseSelect_Vector64_Single,
                ["BitwiseSelect.Vector64.UInt16"] = BitwiseSelect_Vector64_UInt16,
                ["BitwiseSelect.Vector64.UInt32"] = BitwiseSelect_Vector64_UInt32,
                ["BitwiseSelect.Vector64.UInt64"] = BitwiseSelect_Vector64_UInt64,
                ["BitwiseSelect.Vector128.Byte"] = BitwiseSelect_Vector128_Byte,
                ["BitwiseSelect.Vector128.Double"] = BitwiseSelect_Vector128_Double,
                ["BitwiseSelect.Vector128.Int16"] = BitwiseSelect_Vector128_Int16,
                ["BitwiseSelect.Vector128.Int32"] = BitwiseSelect_Vector128_Int32,
                ["BitwiseSelect.Vector128.Int64"] = BitwiseSelect_Vector128_Int64,
                ["BitwiseSelect.Vector128.SByte"] = BitwiseSelect_Vector128_SByte,
                ["BitwiseSelect.Vector128.Single"] = BitwiseSelect_Vector128_Single,
                ["BitwiseSelect.Vector128.UInt16"] = BitwiseSelect_Vector128_UInt16,
                ["BitwiseSelect.Vector128.UInt32"] = BitwiseSelect_Vector128_UInt32,
                ["BitwiseSelect.Vector128.UInt64"] = BitwiseSelect_Vector128_UInt64,
                ["CompareEqual.Vector64.Byte"] = CompareEqual_Vector64_Byte,
                ["CompareEqual.Vector64.Int16"] = CompareEqual_Vector64_Int16,
                ["CompareEqual.Vector64.Int32"] = CompareEqual_Vector64_Int32,
                ["CompareEqual.Vector64.SByte"] = CompareEqual_Vector64_SByte,
                ["CompareEqual.Vector64.Single"] = CompareEqual_Vector64_Single,
                ["CompareEqual.Vector64.UInt16"] = CompareEqual_Vector64_UInt16,
                ["CompareEqual.Vector64.UInt32"] = CompareEqual_Vector64_UInt32,
                ["CompareEqual.Vector128.Byte"] = CompareEqual_Vector128_Byte,
                ["CompareEqual.Vector128.Int16"] = CompareEqual_Vector128_Int16,
                ["CompareEqual.Vector128.Int32"] = CompareEqual_Vector128_Int32,
                ["CompareEqual.Vector128.SByte"] = CompareEqual_Vector128_SByte,
                ["CompareEqual.Vector128.Single"] = CompareEqual_Vector128_Single,
                ["CompareEqual.Vector128.UInt16"] = CompareEqual_Vector128_UInt16,
                ["CompareEqual.Vector128.UInt32"] = CompareEqual_Vector128_UInt32,
                ["CompareGreaterThan.Vector64.Byte"] = CompareGreaterThan_Vector64_Byte,
                ["CompareGreaterThan.Vector64.Int16"] = CompareGreaterThan_Vector64_Int16,
                ["CompareGreaterThan.Vector64.Int32"] = CompareGreaterThan_Vector64_Int32,
                ["CompareGreaterThan.Vector64.SByte"] = CompareGreaterThan_Vector64_SByte,
                ["CompareGreaterThan.Vector64.Single"] = CompareGreaterThan_Vector64_Single,
                ["CompareGreaterThan.Vector64.UInt16"] = CompareGreaterThan_Vector64_UInt16,
                ["CompareGreaterThan.Vector64.UInt32"] = CompareGreaterThan_Vector64_UInt32,
                ["CompareGreaterThan.Vector128.Byte"] = CompareGreaterThan_Vector128_Byte,
                ["CompareGreaterThan.Vector128.Int16"] = CompareGreaterThan_Vector128_Int16,
                ["CompareGreaterThan.Vector128.Int32"] = CompareGreaterThan_Vector128_Int32,
                ["CompareGreaterThan.Vector128.SByte"] = CompareGreaterThan_Vector128_SByte,
                ["CompareGreaterThan.Vector128.Single"] = CompareGreaterThan_Vector128_Single,
                ["CompareGreaterThan.Vector128.UInt16"] = CompareGreaterThan_Vector128_UInt16,
                ["CompareGreaterThan.Vector128.UInt32"] = CompareGreaterThan_Vector128_UInt32,
                ["CompareGreaterThanOrEqual.Vector64.Byte"] = CompareGreaterThanOrEqual_Vector64_Byte,
                ["CompareGreaterThanOrEqual.Vector64.Int16"] = CompareGreaterThanOrEqual_Vector64_Int16,
                ["CompareGreaterThanOrEqual.Vector64.Int32"] = CompareGreaterThanOrEqual_Vector64_Int32,
                ["CompareGreaterThanOrEqual.Vector64.SByte"] = CompareGreaterThanOrEqual_Vector64_SByte,
                ["CompareGreaterThanOrEqual.Vector64.Single"] = CompareGreaterThanOrEqual_Vector64_Single,
                ["CompareGreaterThanOrEqual.Vector64.UInt16"] = CompareGreaterThanOrEqual_Vector64_UInt16,
                ["CompareGreaterThanOrEqual.Vector64.UInt32"] = CompareGreaterThanOrEqual_Vector64_UInt32,
                ["CompareGreaterThanOrEqual.Vector128.Byte"] = CompareGreaterThanOrEqual_Vector128_Byte,
                ["CompareGreaterThanOrEqual.Vector128.Int16"] = CompareGreaterThanOrEqual_Vector128_Int16,
                ["CompareGreaterThanOrEqual.Vector128.Int32"] = CompareGreaterThanOrEqual_Vector128_Int32,
                ["CompareGreaterThanOrEqual.Vector128.SByte"] = CompareGreaterThanOrEqual_Vector128_SByte,
                ["CompareGreaterThanOrEqual.Vector128.Single"] = CompareGreaterThanOrEqual_Vector128_Single,
                ["CompareGreaterThanOrEqual.Vector128.UInt16"] = CompareGreaterThanOrEqual_Vector128_UInt16,
                ["CompareGreaterThanOrEqual.Vector128.UInt32"] = CompareGreaterThanOrEqual_Vector128_UInt32,
                ["CompareLessThan.Vector64.Byte"] = CompareLessThan_Vector64_Byte,
                ["CompareLessThan.Vector64.Int16"] = CompareLessThan_Vector64_Int16,
                ["CompareLessThan.Vector64.Int32"] = CompareLessThan_Vector64_Int32,
                ["CompareLessThan.Vector64.SByte"] = CompareLessThan_Vector64_SByte,
                ["CompareLessThan.Vector64.Single"] = CompareLessThan_Vector64_Single,
                ["CompareLessThan.Vector64.UInt16"] = CompareLessThan_Vector64_UInt16,
                ["CompareLessThan.Vector64.UInt32"] = CompareLessThan_Vector64_UInt32,
                ["CompareLessThan.Vector128.Byte"] = CompareLessThan_Vector128_Byte,
                ["CompareLessThan.Vector128.Int16"] = CompareLessThan_Vector128_Int16,
                ["CompareLessThan.Vector128.Int32"] = CompareLessThan_Vector128_Int32,
                ["CompareLessThan.Vector128.SByte"] = CompareLessThan_Vector128_SByte,
                ["CompareLessThan.Vector128.Single"] = CompareLessThan_Vector128_Single,
                ["CompareLessThan.Vector128.UInt16"] = CompareLessThan_Vector128_UInt16,
                ["CompareLessThan.Vector128.UInt32"] = CompareLessThan_Vector128_UInt32,
                ["CompareLessThanOrEqual.Vector64.Byte"] = CompareLessThanOrEqual_Vector64_Byte,
                ["CompareLessThanOrEqual.Vector64.Int16"] = CompareLessThanOrEqual_Vector64_Int16,
                ["CompareLessThanOrEqual.Vector64.Int32"] = CompareLessThanOrEqual_Vector64_Int32,
                ["CompareLessThanOrEqual.Vector64.SByte"] = CompareLessThanOrEqual_Vector64_SByte,
                ["CompareLessThanOrEqual.Vector64.Single"] = CompareLessThanOrEqual_Vector64_Single,
                ["CompareLessThanOrEqual.Vector64.UInt16"] = CompareLessThanOrEqual_Vector64_UInt16,
                ["CompareLessThanOrEqual.Vector64.UInt32"] = CompareLessThanOrEqual_Vector64_UInt32,
                ["CompareLessThanOrEqual.Vector128.Byte"] = CompareLessThanOrEqual_Vector128_Byte,
                ["CompareLessThanOrEqual.Vector128.Int16"] = CompareLessThanOrEqual_Vector128_Int16,
                ["CompareLessThanOrEqual.Vector128.Int32"] = CompareLessThanOrEqual_Vector128_Int32,
                ["CompareLessThanOrEqual.Vector128.SByte"] = CompareLessThanOrEqual_Vector128_SByte,
                ["CompareLessThanOrEqual.Vector128.Single"] = CompareLessThanOrEqual_Vector128_Single,
                ["CompareLessThanOrEqual.Vector128.UInt16"] = CompareLessThanOrEqual_Vector128_UInt16,
                ["CompareLessThanOrEqual.Vector128.UInt32"] = CompareLessThanOrEqual_Vector128_UInt32,
                ["CompareTest.Vector64.Byte"] = CompareTest_Vector64_Byte,
                ["CompareTest.Vector64.Int16"] = CompareTest_Vector64_Int16,
                ["CompareTest.Vector64.Int32"] = CompareTest_Vector64_Int32,
                ["CompareTest.Vector64.SByte"] = CompareTest_Vector64_SByte,
                ["CompareTest.Vector64.Single"] = CompareTest_Vector64_Single,
                ["CompareTest.Vector64.UInt16"] = CompareTest_Vector64_UInt16,
                ["CompareTest.Vector64.UInt32"] = CompareTest_Vector64_UInt32,
                ["CompareTest.Vector128.Byte"] = CompareTest_Vector128_Byte,
                ["CompareTest.Vector128.Int16"] = CompareTest_Vector128_Int16,
                ["CompareTest.Vector128.Int32"] = CompareTest_Vector128_Int32,
                ["CompareTest.Vector128.SByte"] = CompareTest_Vector128_SByte,
                ["CompareTest.Vector128.Single"] = CompareTest_Vector128_Single,
                ["CompareTest.Vector128.UInt16"] = CompareTest_Vector128_UInt16,
                ["CompareTest.Vector128.UInt32"] = CompareTest_Vector128_UInt32,
                ["DivideScalar.Vector64.Double"] = DivideScalar_Vector64_Double,
                ["DivideScalar.Vector64.Single"] = DivideScalar_Vector64_Single,
                ["FusedMultiplyAdd.Vector64.Single"] = FusedMultiplyAdd_Vector64_Single,
                ["FusedMultiplyAdd.Vector128.Single"] = FusedMultiplyAdd_Vector128_Single,
                ["FusedMultiplyAddScalar.Vector64.Double"] = FusedMultiplyAddScalar_Vector64_Double,
                ["FusedMultiplyAddScalar.Vector64.Single"] = FusedMultiplyAddScalar_Vector64_Single,
                ["FusedMultiplyAddNegatedScalar.Vector64.Double"] = FusedMultiplyAddNegatedScalar_Vector64_Double,
                ["FusedMultiplyAddNegatedScalar.Vector64.Single"] = FusedMultiplyAddNegatedScalar_Vector64_Single,
                ["FusedMultiplySubtract.Vector64.Single"] = FusedMultiplySubtract_Vector64_Single,
                ["FusedMultiplySubtract.Vector128.Single"] = FusedMultiplySubtract_Vector128_Single,
                ["FusedMultiplySubtractScalar.Vector64.Double"] = FusedMultiplySubtractScalar_Vector64_Double,
                ["FusedMultiplySubtractScalar.Vector64.Single"] = FusedMultiplySubtractScalar_Vector64_Single,
                ["FusedMultiplySubtractNegatedScalar.Vector64.Double"] = FusedMultiplySubtractNegatedScalar_Vector64_Double,
                ["FusedMultiplySubtractNegatedScalar.Vector64.Single"] = FusedMultiplySubtractNegatedScalar_Vector64_Single,
                ["LeadingSignCount.Vector64.Int16"] = LeadingSignCount_Vector64_Int16,
                ["LeadingSignCount.Vector64.Int32"] = LeadingSignCount_Vector64_Int32,
                ["LeadingSignCount.Vector64.SByte"] = LeadingSignCount_Vector64_SByte,
                ["LeadingSignCount.Vector128.Int16"] = LeadingSignCount_Vector128_Int16,
                ["LeadingSignCount.Vector128.Int32"] = LeadingSignCount_Vector128_Int32,
                ["LeadingSignCount.Vector128.SByte"] = LeadingSignCount_Vector128_SByte,
                ["LeadingZeroCount.Vector64.Byte"] = LeadingZeroCount_Vector64_Byte,
                ["LeadingZeroCount.Vector64.Int16"] = LeadingZeroCount_Vector64_Int16,
                ["LeadingZeroCount.Vector64.Int32"] = LeadingZeroCount_Vector64_Int32,
                ["LeadingZeroCount.Vector64.SByte"] = LeadingZeroCount_Vector64_SByte,
                ["LeadingZeroCount.Vector64.UInt16"] = LeadingZeroCount_Vector64_UInt16,
                ["LeadingZeroCount.Vector64.UInt32"] = LeadingZeroCount_Vector64_UInt32,
                ["LeadingZeroCount.Vector128.Byte"] = LeadingZeroCount_Vector128_Byte,
                ["LeadingZeroCount.Vector128.Int16"] = LeadingZeroCount_Vector128_Int16,
                ["LeadingZeroCount.Vector128.Int32"] = LeadingZeroCount_Vector128_Int32,
                ["LeadingZeroCount.Vector128.SByte"] = LeadingZeroCount_Vector128_SByte,
                ["LeadingZeroCount.Vector128.UInt16"] = LeadingZeroCount_Vector128_UInt16,
                ["LeadingZeroCount.Vector128.UInt32"] = LeadingZeroCount_Vector128_UInt32,
                ["LoadVector64.Byte"] = LoadVector64_Byte,
                ["LoadVector64.Double"] = LoadVector64_Double,
                ["LoadVector64.Int16"] = LoadVector64_Int16,
                ["LoadVector64.Int32"] = LoadVector64_Int32,
                ["LoadVector64.Int64"] = LoadVector64_Int64,
                ["LoadVector64.SByte"] = LoadVector64_SByte,
                ["LoadVector64.Single"] = LoadVector64_Single,
                ["LoadVector64.UInt16"] = LoadVector64_UInt16,
                ["LoadVector64.UInt32"] = LoadVector64_UInt32,
                ["LoadVector64.UInt64"] = LoadVector64_UInt64,
                ["LoadVector128.Byte"] = LoadVector128_Byte,
                ["LoadVector128.Double"] = LoadVector128_Double,
                ["LoadVector128.Int16"] = LoadVector128_Int16,
                ["LoadVector128.Int32"] = LoadVector128_Int32,
                ["LoadVector128.Int64"] = LoadVector128_Int64,
                ["LoadVector128.SByte"] = LoadVector128_SByte,
                ["LoadVector128.Single"] = LoadVector128_Single,
                ["LoadVector128.UInt16"] = LoadVector128_UInt16,
                ["LoadVector128.UInt32"] = LoadVector128_UInt32,
                ["LoadVector128.UInt64"] = LoadVector128_UInt64,
                ["Max.Vector64.Byte"] = Max_Vector64_Byte,
                ["Max.Vector64.Int16"] = Max_Vector64_Int16,
                ["Max.Vector64.Int32"] = Max_Vector64_Int32,
                ["Max.Vector64.SByte"] = Max_Vector64_SByte,
                ["Max.Vector64.Single"] = Max_Vector64_Single,
                ["Max.Vector64.UInt16"] = Max_Vector64_UInt16,
                ["Max.Vector64.UInt32"] = Max_Vector64_UInt32,
                ["Max.Vector128.Byte"] = Max_Vector128_Byte,
                ["Max.Vector128.Int16"] = Max_Vector128_Int16,
                ["Max.Vector128.Int32"] = Max_Vector128_Int32,
                ["Max.Vector128.SByte"] = Max_Vector128_SByte,
                ["Max.Vector128.Single"] = Max_Vector128_Single,
                ["Max.Vector128.UInt16"] = Max_Vector128_UInt16,
                ["Max.Vector128.UInt32"] = Max_Vector128_UInt32,
                ["MaxNumber.Vector64.Single"] = MaxNumber_Vector64_Single,
                ["MaxNumber.Vector128.Single"] = MaxNumber_Vector128_Single,
                ["MaxNumberScalar.Vector64.Double"] = MaxNumberScalar_Vector64_Double,
                ["MaxNumberScalar.Vector64.Single"] = MaxNumberScalar_Vector64_Single,
                ["MaxPairwise.Vector64.Byte"] = MaxPairwise_Vector64_Byte,
                ["MaxPairwise.Vector64.Int16"] = MaxPairwise_Vector64_Int16,
                ["MaxPairwise.Vector64.Int32"] = MaxPairwise_Vector64_Int32,
                ["MaxPairwise.Vector64.SByte"] = MaxPairwise_Vector64_SByte,
                ["MaxPairwise.Vector64.Single"] = MaxPairwise_Vector64_Single,
                ["MaxPairwise.Vector64.UInt16"] = MaxPairwise_Vector64_UInt16,
                ["MaxPairwise.Vector64.UInt32"] = MaxPairwise_Vector64_UInt32,
                ["Min.Vector64.Byte"] = Min_Vector64_Byte,
                ["Min.Vector64.Int16"] = Min_Vector64_Int16,
                ["Min.Vector64.Int32"] = Min_Vector64_Int32,
                ["Min.Vector64.SByte"] = Min_Vector64_SByte,
                ["Min.Vector64.Single"] = Min_Vector64_Single,
                ["Min.Vector64.UInt16"] = Min_Vector64_UInt16,
                ["Min.Vector64.UInt32"] = Min_Vector64_UInt32,
                ["Min.Vector128.Byte"] = Min_Vector128_Byte,
                ["Min.Vector128.Int16"] = Min_Vector128_Int16,
                ["Min.Vector128.Int32"] = Min_Vector128_Int32,
                ["Min.Vector128.SByte"] = Min_Vector128_SByte,
                ["Min.Vector128.Single"] = Min_Vector128_Single,
                ["Min.Vector128.UInt16"] = Min_Vector128_UInt16,
                ["Min.Vector128.UInt32"] = Min_Vector128_UInt32,
                ["MinNumber.Vector64.Single"] = MinNumber_Vector64_Single,
                ["MinNumber.Vector128.Single"] = MinNumber_Vector128_Single,
                ["MinNumberScalar.Vector64.Double"] = MinNumberScalar_Vector64_Double,
                ["MinNumberScalar.Vector64.Single"] = MinNumberScalar_Vector64_Single,
                ["MinPairwise.Vector64.Byte"] = MinPairwise_Vector64_Byte,
                ["MinPairwise.Vector64.Int16"] = MinPairwise_Vector64_Int16,
                ["MinPairwise.Vector64.Int32"] = MinPairwise_Vector64_Int32,
                ["MinPairwise.Vector64.SByte"] = MinPairwise_Vector64_SByte,
                ["MinPairwise.Vector64.Single"] = MinPairwise_Vector64_Single,
                ["MinPairwise.Vector64.UInt16"] = MinPairwise_Vector64_UInt16,
                ["MinPairwise.Vector64.UInt32"] = MinPairwise_Vector64_UInt32,
                ["Multiply.Vector64.Byte"] = Multiply_Vector64_Byte,
                ["Multiply.Vector64.Int16"] = Multiply_Vector64_Int16,
                ["Multiply.Vector64.Int32"] = Multiply_Vector64_Int32,
                ["Multiply.Vector64.SByte"] = Multiply_Vector64_SByte,
                ["Multiply.Vector64.Single"] = Multiply_Vector64_Single,
                ["Multiply.Vector64.UInt16"] = Multiply_Vector64_UInt16,
                ["Multiply.Vector64.UInt32"] = Multiply_Vector64_UInt32,
                ["Multiply.Vector128.Byte"] = Multiply_Vector128_Byte,
                ["Multiply.Vector128.Int16"] = Multiply_Vector128_Int16,
                ["Multiply.Vector128.Int32"] = Multiply_Vector128_Int32,
                ["Multiply.Vector128.SByte"] = Multiply_Vector128_SByte,
                ["Multiply.Vector128.Single"] = Multiply_Vector128_Single,
                ["Multiply.Vector128.UInt16"] = Multiply_Vector128_UInt16,
                ["Multiply.Vector128.UInt32"] = Multiply_Vector128_UInt32,
                ["MultiplyScalar.Vector64.Double"] = MultiplyScalar_Vector64_Double,
                ["MultiplyScalar.Vector64.Single"] = MultiplyScalar_Vector64_Single,
                ["MultiplyAdd.Vector64.Byte"] = MultiplyAdd_Vector64_Byte,
                ["MultiplyAdd.Vector64.Int16"] = MultiplyAdd_Vector64_Int16,
                ["MultiplyAdd.Vector64.Int32"] = MultiplyAdd_Vector64_Int32,
                ["MultiplyAdd.Vector64.SByte"] = MultiplyAdd_Vector64_SByte,
                ["MultiplyAdd.Vector64.UInt16"] = MultiplyAdd_Vector64_UInt16,
                ["MultiplyAdd.Vector64.UInt32"] = MultiplyAdd_Vector64_UInt32,
                ["MultiplyAdd.Vector128.Byte"] = MultiplyAdd_Vector128_Byte,
                ["MultiplyAdd.Vector128.Int16"] = MultiplyAdd_Vector128_Int16,
                ["MultiplyAdd.Vector128.Int32"] = MultiplyAdd_Vector128_Int32,
                ["MultiplyAdd.Vector128.SByte"] = MultiplyAdd_Vector128_SByte,
                ["MultiplyAdd.Vector128.UInt16"] = MultiplyAdd_Vector128_UInt16,
                ["MultiplyAdd.Vector128.UInt32"] = MultiplyAdd_Vector128_UInt32,
                ["MultiplySubtract.Vector64.Byte"] = MultiplySubtract_Vector64_Byte,
                ["MultiplySubtract.Vector64.Int16"] = MultiplySubtract_Vector64_Int16,
                ["MultiplySubtract.Vector64.Int32"] = MultiplySubtract_Vector64_Int32,
                ["MultiplySubtract.Vector64.SByte"] = MultiplySubtract_Vector64_SByte,
                ["MultiplySubtract.Vector64.UInt16"] = MultiplySubtract_Vector64_UInt16,
                ["MultiplySubtract.Vector64.UInt32"] = MultiplySubtract_Vector64_UInt32,
                ["MultiplySubtract.Vector128.Byte"] = MultiplySubtract_Vector128_Byte,
                ["MultiplySubtract.Vector128.Int16"] = MultiplySubtract_Vector128_Int16,
                ["MultiplySubtract.Vector128.Int32"] = MultiplySubtract_Vector128_Int32,
                ["MultiplySubtract.Vector128.SByte"] = MultiplySubtract_Vector128_SByte,
                ["MultiplySubtract.Vector128.UInt16"] = MultiplySubtract_Vector128_UInt16,
                ["MultiplySubtract.Vector128.UInt32"] = MultiplySubtract_Vector128_UInt32,
                ["Negate.Vector64.Int16"] = Negate_Vector64_Int16,
                ["Negate.Vector64.Int32"] = Negate_Vector64_Int32,
                ["Negate.Vector64.SByte"] = Negate_Vector64_SByte,
                ["Negate.Vector64.Single"] = Negate_Vector64_Single,
                ["Negate.Vector128.Int16"] = Negate_Vector128_Int16,
                ["Negate.Vector128.Int32"] = Negate_Vector128_Int32,
                ["Negate.Vector128.SByte"] = Negate_Vector128_SByte,
                ["Negate.Vector128.Single"] = Negate_Vector128_Single,
                ["NegateScalar.Vector64.Double"] = NegateScalar_Vector64_Double,
                ["NegateScalar.Vector64.Single"] = NegateScalar_Vector64_Single,
                ["Not.Vector64.Byte"] = Not_Vector64_Byte,
                ["Not.Vector64.Double"] = Not_Vector64_Double,
                ["Not.Vector64.Int16"] = Not_Vector64_Int16,
                ["Not.Vector64.Int32"] = Not_Vector64_Int32,
                ["Not.Vector64.Int64"] = Not_Vector64_Int64,
                ["Not.Vector64.SByte"] = Not_Vector64_SByte,
                ["Not.Vector64.Single"] = Not_Vector64_Single,
                ["Not.Vector64.UInt16"] = Not_Vector64_UInt16,
                ["Not.Vector64.UInt32"] = Not_Vector64_UInt32,
                ["Not.Vector64.UInt64"] = Not_Vector64_UInt64,
                ["Not.Vector128.Byte"] = Not_Vector128_Byte,
                ["Not.Vector128.Double"] = Not_Vector128_Double,
                ["Not.Vector128.Int16"] = Not_Vector128_Int16,
                ["Not.Vector128.Int32"] = Not_Vector128_Int32,
                ["Not.Vector128.Int64"] = Not_Vector128_Int64,
                ["Not.Vector128.SByte"] = Not_Vector128_SByte,
                ["Not.Vector128.Single"] = Not_Vector128_Single,
                ["Not.Vector128.UInt16"] = Not_Vector128_UInt16,
                ["Not.Vector128.UInt32"] = Not_Vector128_UInt32,
                ["Not.Vector128.UInt64"] = Not_Vector128_UInt64,
                ["Or.Vector64.Byte"] = Or_Vector64_Byte,
                ["Or.Vector64.Double"] = Or_Vector64_Double,
                ["Or.Vector64.Int16"] = Or_Vector64_Int16,
                ["Or.Vector64.Int32"] = Or_Vector64_Int32,
                ["Or.Vector64.Int64"] = Or_Vector64_Int64,
                ["Or.Vector64.SByte"] = Or_Vector64_SByte,
                ["Or.Vector64.Single"] = Or_Vector64_Single,
                ["Or.Vector64.UInt16"] = Or_Vector64_UInt16,
                ["Or.Vector64.UInt32"] = Or_Vector64_UInt32,
                ["Or.Vector64.UInt64"] = Or_Vector64_UInt64,
                ["Or.Vector128.Byte"] = Or_Vector128_Byte,
                ["Or.Vector128.Double"] = Or_Vector128_Double,
                ["Or.Vector128.Int16"] = Or_Vector128_Int16,
                ["Or.Vector128.Int32"] = Or_Vector128_Int32,
                ["Or.Vector128.Int64"] = Or_Vector128_Int64,
                ["Or.Vector128.SByte"] = Or_Vector128_SByte,
                ["Or.Vector128.Single"] = Or_Vector128_Single,
                ["Or.Vector128.UInt16"] = Or_Vector128_UInt16,
                ["Or.Vector128.UInt32"] = Or_Vector128_UInt32,
                ["Or.Vector128.UInt64"] = Or_Vector128_UInt64,
                ["OrNot.Vector64.Byte"] = OrNot_Vector64_Byte,
                ["OrNot.Vector64.Double"] = OrNot_Vector64_Double,
                ["OrNot.Vector64.Int16"] = OrNot_Vector64_Int16,
                ["OrNot.Vector64.Int32"] = OrNot_Vector64_Int32,
                ["OrNot.Vector64.Int64"] = OrNot_Vector64_Int64,
                ["OrNot.Vector64.SByte"] = OrNot_Vector64_SByte,
                ["OrNot.Vector64.Single"] = OrNot_Vector64_Single,
                ["OrNot.Vector64.UInt16"] = OrNot_Vector64_UInt16,
                ["OrNot.Vector64.UInt32"] = OrNot_Vector64_UInt32,
                ["OrNot.Vector64.UInt64"] = OrNot_Vector64_UInt64,
                ["OrNot.Vector128.Byte"] = OrNot_Vector128_Byte,
                ["OrNot.Vector128.Double"] = OrNot_Vector128_Double,
                ["OrNot.Vector128.Int16"] = OrNot_Vector128_Int16,
                ["OrNot.Vector128.Int32"] = OrNot_Vector128_Int32,
                ["OrNot.Vector128.Int64"] = OrNot_Vector128_Int64,
                ["OrNot.Vector128.SByte"] = OrNot_Vector128_SByte,
                ["OrNot.Vector128.Single"] = OrNot_Vector128_Single,
                ["OrNot.Vector128.UInt16"] = OrNot_Vector128_UInt16,
                ["OrNot.Vector128.UInt32"] = OrNot_Vector128_UInt32,
                ["OrNot.Vector128.UInt64"] = OrNot_Vector128_UInt64,
                ["PopCount.Vector64.Byte"] = PopCount_Vector64_Byte,
                ["PopCount.Vector64.SByte"] = PopCount_Vector64_SByte,
                ["PopCount.Vector128.Byte"] = PopCount_Vector128_Byte,
                ["PopCount.Vector128.SByte"] = PopCount_Vector128_SByte,
                ["SqrtScalar.Vector64.Double"] = SqrtScalar_Vector64_Double,
                ["SqrtScalar.Vector64.Single"] = SqrtScalar_Vector64_Single,
                ["Subtract.Vector64.Byte"] = Subtract_Vector64_Byte,
                ["Subtract.Vector64.Int16"] = Subtract_Vector64_Int16,
                ["Subtract.Vector64.Int32"] = Subtract_Vector64_Int32,
                ["Subtract.Vector64.SByte"] = Subtract_Vector64_SByte,
                ["Subtract.Vector64.Single"] = Subtract_Vector64_Single,
                ["Subtract.Vector64.UInt16"] = Subtract_Vector64_UInt16,
                ["Subtract.Vector64.UInt32"] = Subtract_Vector64_UInt32,
                ["Subtract.Vector128.Byte"] = Subtract_Vector128_Byte,
                ["Subtract.Vector128.Int16"] = Subtract_Vector128_Int16,
                ["Subtract.Vector128.Int32"] = Subtract_Vector128_Int32,
                ["Subtract.Vector128.Int64"] = Subtract_Vector128_Int64,
                ["Subtract.Vector128.SByte"] = Subtract_Vector128_SByte,
                ["Subtract.Vector128.Single"] = Subtract_Vector128_Single,
                ["Subtract.Vector128.UInt16"] = Subtract_Vector128_UInt16,
                ["Subtract.Vector128.UInt32"] = Subtract_Vector128_UInt32,
                ["Subtract.Vector128.UInt64"] = Subtract_Vector128_UInt64,
                ["SubtractScalar.Vector64.Double"] = SubtractScalar_Vector64_Double,
                ["SubtractScalar.Vector64.Int64"] = SubtractScalar_Vector64_Int64,
                ["SubtractScalar.Vector64.Single"] = SubtractScalar_Vector64_Single,
                ["SubtractScalar.Vector64.UInt64"] = SubtractScalar_Vector64_UInt64,
                ["Xor.Vector64.Byte"] = Xor_Vector64_Byte,
                ["Xor.Vector64.Double"] = Xor_Vector64_Double,
                ["Xor.Vector64.Int16"] = Xor_Vector64_Int16,
                ["Xor.Vector64.Int32"] = Xor_Vector64_Int32,
                ["Xor.Vector64.Int64"] = Xor_Vector64_Int64,
                ["Xor.Vector64.SByte"] = Xor_Vector64_SByte,
                ["Xor.Vector64.Single"] = Xor_Vector64_Single,
                ["Xor.Vector64.UInt16"] = Xor_Vector64_UInt16,
                ["Xor.Vector64.UInt32"] = Xor_Vector64_UInt32,
                ["Xor.Vector64.UInt64"] = Xor_Vector64_UInt64,
                ["Xor.Vector128.Byte"] = Xor_Vector128_Byte,
                ["Xor.Vector128.Double"] = Xor_Vector128_Double,
                ["Xor.Vector128.Int16"] = Xor_Vector128_Int16,
                ["Xor.Vector128.Int32"] = Xor_Vector128_Int32,
                ["Xor.Vector128.Int64"] = Xor_Vector128_Int64,
                ["Xor.Vector128.SByte"] = Xor_Vector128_SByte,
                ["Xor.Vector128.Single"] = Xor_Vector128_Single,
                ["Xor.Vector128.UInt16"] = Xor_Vector128_UInt16,
                ["Xor.Vector128.UInt32"] = Xor_Vector128_UInt32,
                ["Xor.Vector128.UInt64"] = Xor_Vector128_UInt64,
            };
        }
    }
}
