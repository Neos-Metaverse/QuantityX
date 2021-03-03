/* *****************************************************************************
 * Author: Tomas "Frooxius" Mariancik (www.frooxius.com)
 * Date: 09/20/2014
 * 
 * Summary: Quantity prototype with SI Units
 * *****************************************************************************/

using System;

namespace QuantityX
{
    public struct Mass : IQuantitySI<Mass>
    {
        #region ESSENTIALS

        // this section can be simply left as is, but rename Mass

        // Base unit is gram!!!
        public double BaseValue { get; private set; }

        public Mass(double baseValue = 0) : this()  { BaseValue = baseValue; }

        public bool Equals(Mass other) { return BaseValue == other.BaseValue; }
        public int CompareTo(Mass other) { return BaseValue.CompareTo(other.BaseValue); }

        #endregion

        /* *********************************************** */

        #region QUANTITY NAME DEFINITIONS

        // Provide at least one short and one long name for the quantity
        // The first entry will be used for formatting, all will be used for parsing

        public string[] GetShortBaseNames() { return new string[] { "g" }; }
        public string[] GetLongBaseNames()
        { return new string[] { "grams", "gram" }; }

        #endregion

        /* *********************************************** */

        #region SI UNIT DEFINITIONS

        // the SI factor will be adjusted for this
        public double SIPower { get { return 1; } }

        // these units will be automatically registered in the Common groups
        public IUnit[] GetCommonSIUnits()
        {
            return new IUnit[] {
                SI<Mass>.Kilo,
                Gram,
                SI<Mass>.Milli,
                SI<Mass>.Micro,
                SI<Mass>.Nano,
                SI<Mass>.Pico
            };
        }

        // these SI units will never be used for formatting, unless used explicitly
        public IUnit[] GetExludedSIUnits()
        {
            return new IUnit[] {
                SI<Mass>.Hecto,
                SI<Mass>.Mega,  // use Ton instead
            };
        }

        #endregion

        /* *********************************************** */

        #region UNITS

        // provide a default unit for the quantity - used when no explicit unit specified
        public Unit<Mass> DefaultUnit { get { return SI<Mass>.Kilo; } }

        // define actual units for the quantity (excluding SI units which are automatic)
        // Parameters:

        public static readonly Unit<Mass> Gram = new UnitSI<Mass>(0, "", "");

        public static readonly Unit<Mass> Ton = new Unit<Mass>(1e6,
            new UnitGroup[] { UnitGroup.Common, UnitGroup.Metric },
            new string[] { " t" }, new string[] { " tonnes" });

        #endregion

        /* *********************************************** */

        #region OPERATORS

        public Mass New(double baseVal) { return new Mass(baseVal); }

        public Mass Add(Mass q) { return new Mass(BaseValue + q.BaseValue); }
        public Mass Subtract(Mass q) { return new Mass(BaseValue - q.BaseValue); }

        public Mass Multiply(double n) { return new Mass(BaseValue * n); }
        public Mass Multiply(Mass a, Ratio r) { return a * r.BaseValue; }
        public Mass Multiply(Ratio r, Mass a) { return a * r.BaseValue; }

        public Mass Divide(double n) { return new Mass(BaseValue / n); }
        public Ratio Divide(Mass q) { return new Ratio(BaseValue / q.BaseValue); }

        // these should be defined as convenience, but cannot be forced by interface
        public static Mass Parse(string str, Unit<Mass> defaultUnit = null) { return Unit<Mass>.Parse(str, defaultUnit); }
        public static bool TryParse(string str, out Mass q, Unit<Mass> defaultUnit = null) { return Unit<Mass>.TryParse(str, out q, defaultUnit); }

        public static Mass operator +(Mass a, Mass b) { return a.Add(b); }
        public static Mass operator -(Mass a, Mass b) { return a.Subtract(b); }
        public static Mass operator *(Mass a, double n) { return a.Multiply(n); }
        public static Mass operator /(Mass a, double n) { return a.Divide(n); }
        public static Ratio operator /(Mass a, Mass b) { return a.Divide(b); }
        public static Mass operator -(Mass a) { return a.Multiply(-1); }

        #endregion

        /* *********************************************** */

        #region CONVERSIONS

        // provide various operators to convert between quantities or adjust the quantity

        #endregion

        /* *********************************************** */
    }
}
