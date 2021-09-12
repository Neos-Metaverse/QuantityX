/* *****************************************************************************
 * Author: Tomas "Frooxius" Mariancik (www.frooxius.com)
 * Date: 09/19/2014
 * 
 * Summary: Definitions of all SI units for quantity types that use SI prefixes
 * *****************************************************************************/

namespace QuantityX
{
    public static class SI<T> where T : IQuantitySI<T>
    {
        public static readonly UnitSI<T> Yocto = new UnitSI<T>(-24, "y", "yocto");
        public static readonly UnitSI<T> Zepto = new UnitSI<T>(-21, "z", "zepto");
        public static readonly UnitSI<T> Atto = new UnitSI<T>(-18, "a", "atto");
        public static readonly UnitSI<T> Femto = new UnitSI<T>(-15, "f", "femto");
        public static readonly UnitSI<T> Pico = new UnitSI<T>(-12, "p", "pico");
        public static readonly UnitSI<T> Nano = new UnitSI<T>(-9, "n", "nano");
        public static readonly UnitSI<T> Micro = new UnitSI<T>(-6, "µ", "micro");
        public static readonly UnitSI<T> Milli = new UnitSI<T>(-3, "m", "milli");

        public static readonly UnitSI<T> Centi = new UnitSI<T>(-2, "c", "centi");
        public static readonly UnitSI<T> Deci = new UnitSI<T>(-1, "d", "deci");

        public static readonly UnitSI<T> Deca = new UnitSI<T>(1, "da", "deca");
        public static readonly UnitSI<T> Hecto = new UnitSI<T>(2, "h", "hecto");
            
        public static readonly UnitSI<T> Kilo = new UnitSI<T>(3, "k", "kilo");
        public static readonly UnitSI<T> Mega = new UnitSI<T>(6, "M", "mega");
        public static readonly UnitSI<T> Giga = new UnitSI<T>(9, "G", "giga");
        public static readonly UnitSI<T> Tera = new UnitSI<T>(12, "T", "tera");
        public static readonly UnitSI<T> Peta = new UnitSI<T>(15, "P", "peta");
        public static readonly UnitSI<T> Exa = new UnitSI<T>(18, "E", "exa");
        public static readonly UnitSI<T> Zetta = new UnitSI<T>(21, "Z", "zetta");
        public static readonly UnitSI<T> Yotta = new UnitSI<T>(24, "Y", "yotta");
    }
}
