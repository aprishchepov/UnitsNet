﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions.NumberToDensity
{
    public static class NumberToDensityExtensions
    {
        #region GramPerCubicCentimeter

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double)"/>
        public static Density GramsPerCubicCentimeter(this int value) => Density.FromGramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double?)"/>
        public static Density? GramsPerCubicCentimeter(this int? value) => Density.FromGramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double)"/>
        public static Density GramsPerCubicCentimeter(this long value) => Density.FromGramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double?)"/>
        public static Density? GramsPerCubicCentimeter(this long? value) => Density.FromGramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double)"/>
        public static Density GramsPerCubicCentimeter(this double value) => Density.FromGramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double?)"/>
        public static Density? GramsPerCubicCentimeter(this double? value) => Density.FromGramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double)"/>
        public static Density GramsPerCubicCentimeter(this float value) => Density.FromGramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double?)"/>
        public static Density? GramsPerCubicCentimeter(this float? value) => Density.FromGramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double)"/>
        public static Density GramsPerCubicCentimeter(this decimal value) => Density.FromGramsPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(double?)"/>
        public static Density? GramsPerCubicCentimeter(this decimal? value) => Density.FromGramsPerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerCubicMeter

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double)"/>
        public static Density GramsPerCubicMeter(this int value) => Density.FromGramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double?)"/>
        public static Density? GramsPerCubicMeter(this int? value) => Density.FromGramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double)"/>
        public static Density GramsPerCubicMeter(this long value) => Density.FromGramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double?)"/>
        public static Density? GramsPerCubicMeter(this long? value) => Density.FromGramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double)"/>
        public static Density GramsPerCubicMeter(this double value) => Density.FromGramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double?)"/>
        public static Density? GramsPerCubicMeter(this double? value) => Density.FromGramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double)"/>
        public static Density GramsPerCubicMeter(this float value) => Density.FromGramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double?)"/>
        public static Density? GramsPerCubicMeter(this float? value) => Density.FromGramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double)"/>
        public static Density GramsPerCubicMeter(this decimal value) => Density.FromGramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(double?)"/>
        public static Density? GramsPerCubicMeter(this decimal? value) => Density.FromGramsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerCubicMillimeter

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double)"/>
        public static Density GramsPerCubicMillimeter(this int value) => Density.FromGramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double?)"/>
        public static Density? GramsPerCubicMillimeter(this int? value) => Density.FromGramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double)"/>
        public static Density GramsPerCubicMillimeter(this long value) => Density.FromGramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double?)"/>
        public static Density? GramsPerCubicMillimeter(this long? value) => Density.FromGramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double)"/>
        public static Density GramsPerCubicMillimeter(this double value) => Density.FromGramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double?)"/>
        public static Density? GramsPerCubicMillimeter(this double? value) => Density.FromGramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double)"/>
        public static Density GramsPerCubicMillimeter(this float value) => Density.FromGramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double?)"/>
        public static Density? GramsPerCubicMillimeter(this float? value) => Density.FromGramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double)"/>
        public static Density GramsPerCubicMillimeter(this decimal value) => Density.FromGramsPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(double?)"/>
        public static Density? GramsPerCubicMillimeter(this decimal? value) => Density.FromGramsPerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramPerCubicCentimeter

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double)"/>
        public static Density KilogramsPerCubicCentimeter(this int value) => Density.FromKilogramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double?)"/>
        public static Density? KilogramsPerCubicCentimeter(this int? value) => Density.FromKilogramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double)"/>
        public static Density KilogramsPerCubicCentimeter(this long value) => Density.FromKilogramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double?)"/>
        public static Density? KilogramsPerCubicCentimeter(this long? value) => Density.FromKilogramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double)"/>
        public static Density KilogramsPerCubicCentimeter(this double value) => Density.FromKilogramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double?)"/>
        public static Density? KilogramsPerCubicCentimeter(this double? value) => Density.FromKilogramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double)"/>
        public static Density KilogramsPerCubicCentimeter(this float value) => Density.FromKilogramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double?)"/>
        public static Density? KilogramsPerCubicCentimeter(this float? value) => Density.FromKilogramsPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double)"/>
        public static Density KilogramsPerCubicCentimeter(this decimal value) => Density.FromKilogramsPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(double?)"/>
        public static Density? KilogramsPerCubicCentimeter(this decimal? value) => Density.FromKilogramsPerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramPerCubicMeter

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double)"/>
        public static Density KilogramsPerCubicMeter(this int value) => Density.FromKilogramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double?)"/>
        public static Density? KilogramsPerCubicMeter(this int? value) => Density.FromKilogramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double)"/>
        public static Density KilogramsPerCubicMeter(this long value) => Density.FromKilogramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double?)"/>
        public static Density? KilogramsPerCubicMeter(this long? value) => Density.FromKilogramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double)"/>
        public static Density KilogramsPerCubicMeter(this double value) => Density.FromKilogramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double?)"/>
        public static Density? KilogramsPerCubicMeter(this double? value) => Density.FromKilogramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double)"/>
        public static Density KilogramsPerCubicMeter(this float value) => Density.FromKilogramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double?)"/>
        public static Density? KilogramsPerCubicMeter(this float? value) => Density.FromKilogramsPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double)"/>
        public static Density KilogramsPerCubicMeter(this decimal value) => Density.FromKilogramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(double?)"/>
        public static Density? KilogramsPerCubicMeter(this decimal? value) => Density.FromKilogramsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramPerCubicMillimeter

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double)"/>
        public static Density KilogramsPerCubicMillimeter(this int value) => Density.FromKilogramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double?)"/>
        public static Density? KilogramsPerCubicMillimeter(this int? value) => Density.FromKilogramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double)"/>
        public static Density KilogramsPerCubicMillimeter(this long value) => Density.FromKilogramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double?)"/>
        public static Density? KilogramsPerCubicMillimeter(this long? value) => Density.FromKilogramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double)"/>
        public static Density KilogramsPerCubicMillimeter(this double value) => Density.FromKilogramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double?)"/>
        public static Density? KilogramsPerCubicMillimeter(this double? value) => Density.FromKilogramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double)"/>
        public static Density KilogramsPerCubicMillimeter(this float value) => Density.FromKilogramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double?)"/>
        public static Density? KilogramsPerCubicMillimeter(this float? value) => Density.FromKilogramsPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double)"/>
        public static Density KilogramsPerCubicMillimeter(this decimal value) => Density.FromKilogramsPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(double?)"/>
        public static Density? KilogramsPerCubicMillimeter(this decimal? value) => Density.FromKilogramsPerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundPerCubicFoot

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double)"/>
        public static Density KilopoundsPerCubicFoot(this int value) => Density.FromKilopoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double?)"/>
        public static Density? KilopoundsPerCubicFoot(this int? value) => Density.FromKilopoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double)"/>
        public static Density KilopoundsPerCubicFoot(this long value) => Density.FromKilopoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double?)"/>
        public static Density? KilopoundsPerCubicFoot(this long? value) => Density.FromKilopoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double)"/>
        public static Density KilopoundsPerCubicFoot(this double value) => Density.FromKilopoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double?)"/>
        public static Density? KilopoundsPerCubicFoot(this double? value) => Density.FromKilopoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double)"/>
        public static Density KilopoundsPerCubicFoot(this float value) => Density.FromKilopoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double?)"/>
        public static Density? KilopoundsPerCubicFoot(this float? value) => Density.FromKilopoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double)"/>
        public static Density KilopoundsPerCubicFoot(this decimal value) => Density.FromKilopoundsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(double?)"/>
        public static Density? KilopoundsPerCubicFoot(this decimal? value) => Density.FromKilopoundsPerCubicFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundPerCubicInch

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double)"/>
        public static Density KilopoundsPerCubicInch(this int value) => Density.FromKilopoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double?)"/>
        public static Density? KilopoundsPerCubicInch(this int? value) => Density.FromKilopoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double)"/>
        public static Density KilopoundsPerCubicInch(this long value) => Density.FromKilopoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double?)"/>
        public static Density? KilopoundsPerCubicInch(this long? value) => Density.FromKilopoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double)"/>
        public static Density KilopoundsPerCubicInch(this double value) => Density.FromKilopoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double?)"/>
        public static Density? KilopoundsPerCubicInch(this double? value) => Density.FromKilopoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double)"/>
        public static Density KilopoundsPerCubicInch(this float value) => Density.FromKilopoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double?)"/>
        public static Density? KilopoundsPerCubicInch(this float? value) => Density.FromKilopoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double)"/>
        public static Density KilopoundsPerCubicInch(this decimal value) => Density.FromKilopoundsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(double?)"/>
        public static Density? KilopoundsPerCubicInch(this decimal? value) => Density.FromKilopoundsPerCubicInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerCubicFoot

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double)"/>
        public static Density PoundsPerCubicFoot(this int value) => Density.FromPoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double?)"/>
        public static Density? PoundsPerCubicFoot(this int? value) => Density.FromPoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double)"/>
        public static Density PoundsPerCubicFoot(this long value) => Density.FromPoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double?)"/>
        public static Density? PoundsPerCubicFoot(this long? value) => Density.FromPoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double)"/>
        public static Density PoundsPerCubicFoot(this double value) => Density.FromPoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double?)"/>
        public static Density? PoundsPerCubicFoot(this double? value) => Density.FromPoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double)"/>
        public static Density PoundsPerCubicFoot(this float value) => Density.FromPoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double?)"/>
        public static Density? PoundsPerCubicFoot(this float? value) => Density.FromPoundsPerCubicFoot(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double)"/>
        public static Density PoundsPerCubicFoot(this decimal value) => Density.FromPoundsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(double?)"/>
        public static Density? PoundsPerCubicFoot(this decimal? value) => Density.FromPoundsPerCubicFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerCubicInch

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double)"/>
        public static Density PoundsPerCubicInch(this int value) => Density.FromPoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double?)"/>
        public static Density? PoundsPerCubicInch(this int? value) => Density.FromPoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double)"/>
        public static Density PoundsPerCubicInch(this long value) => Density.FromPoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double?)"/>
        public static Density? PoundsPerCubicInch(this long? value) => Density.FromPoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double)"/>
        public static Density PoundsPerCubicInch(this double value) => Density.FromPoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double?)"/>
        public static Density? PoundsPerCubicInch(this double? value) => Density.FromPoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double)"/>
        public static Density PoundsPerCubicInch(this float value) => Density.FromPoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double?)"/>
        public static Density? PoundsPerCubicInch(this float? value) => Density.FromPoundsPerCubicInch(value);

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double)"/>
        public static Density PoundsPerCubicInch(this decimal value) => Density.FromPoundsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(double?)"/>
        public static Density? PoundsPerCubicInch(this decimal? value) => Density.FromPoundsPerCubicInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonnePerCubicCentimeter

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double)"/>
        public static Density TonnesPerCubicCentimeter(this int value) => Density.FromTonnesPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double?)"/>
        public static Density? TonnesPerCubicCentimeter(this int? value) => Density.FromTonnesPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double)"/>
        public static Density TonnesPerCubicCentimeter(this long value) => Density.FromTonnesPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double?)"/>
        public static Density? TonnesPerCubicCentimeter(this long? value) => Density.FromTonnesPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double)"/>
        public static Density TonnesPerCubicCentimeter(this double value) => Density.FromTonnesPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double?)"/>
        public static Density? TonnesPerCubicCentimeter(this double? value) => Density.FromTonnesPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double)"/>
        public static Density TonnesPerCubicCentimeter(this float value) => Density.FromTonnesPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double?)"/>
        public static Density? TonnesPerCubicCentimeter(this float? value) => Density.FromTonnesPerCubicCentimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double)"/>
        public static Density TonnesPerCubicCentimeter(this decimal value) => Density.FromTonnesPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(double?)"/>
        public static Density? TonnesPerCubicCentimeter(this decimal? value) => Density.FromTonnesPerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonnePerCubicMeter

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double)"/>
        public static Density TonnesPerCubicMeter(this int value) => Density.FromTonnesPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double?)"/>
        public static Density? TonnesPerCubicMeter(this int? value) => Density.FromTonnesPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double)"/>
        public static Density TonnesPerCubicMeter(this long value) => Density.FromTonnesPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double?)"/>
        public static Density? TonnesPerCubicMeter(this long? value) => Density.FromTonnesPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double)"/>
        public static Density TonnesPerCubicMeter(this double value) => Density.FromTonnesPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double?)"/>
        public static Density? TonnesPerCubicMeter(this double? value) => Density.FromTonnesPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double)"/>
        public static Density TonnesPerCubicMeter(this float value) => Density.FromTonnesPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double?)"/>
        public static Density? TonnesPerCubicMeter(this float? value) => Density.FromTonnesPerCubicMeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double)"/>
        public static Density TonnesPerCubicMeter(this decimal value) => Density.FromTonnesPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(double?)"/>
        public static Density? TonnesPerCubicMeter(this decimal? value) => Density.FromTonnesPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonnePerCubicMillimeter

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double)"/>
        public static Density TonnesPerCubicMillimeter(this int value) => Density.FromTonnesPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double?)"/>
        public static Density? TonnesPerCubicMillimeter(this int? value) => Density.FromTonnesPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double)"/>
        public static Density TonnesPerCubicMillimeter(this long value) => Density.FromTonnesPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double?)"/>
        public static Density? TonnesPerCubicMillimeter(this long? value) => Density.FromTonnesPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double)"/>
        public static Density TonnesPerCubicMillimeter(this double value) => Density.FromTonnesPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double?)"/>
        public static Density? TonnesPerCubicMillimeter(this double? value) => Density.FromTonnesPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double)"/>
        public static Density TonnesPerCubicMillimeter(this float value) => Density.FromTonnesPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double?)"/>
        public static Density? TonnesPerCubicMillimeter(this float? value) => Density.FromTonnesPerCubicMillimeter(value);

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double)"/>
        public static Density TonnesPerCubicMillimeter(this decimal value) => Density.FromTonnesPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(double?)"/>
        public static Density? TonnesPerCubicMillimeter(this decimal? value) => Density.FromTonnesPerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
