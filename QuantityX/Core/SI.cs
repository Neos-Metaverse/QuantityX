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
        public static UnitSI<T> Yocto = new UnitSI<T>(-24, "y", "yocto");
        public static UnitSI<T> Zepto = new UnitSI<T>(-21, "z", "zepto");
        public static UnitSI<T> Atto = new UnitSI<T>(-18, "a", "atto");
        public static UnitSI<T> Femto = new UnitSI<T>(-15, "f", "femto");
        public static UnitSI<T> Pico = new UnitSI<T>(-12, "p", "pico");
        public static UnitSI<T> Nano = new UnitSI<T>(-9, "n", "nano");
        public static UnitSI<T> Micro = new UnitSI<T>(-6, "µ", "micro");
        public static UnitSI<T> Milli = new UnitSI<T>(-3, "m", "milli");

        public static UnitSI<T> Centi = new UnitSI<T>(-2, "c", "centi");
        public static UnitSI<T> Deci = new UnitSI<T>(-1, "d", "deci");

        public static UnitSI<T> Deca = new UnitSI<T>(1, "da", "deca");
        public static UnitSI<T> Hecto = new UnitSI<T>(2, "h", "hecto");
            
        public static UnitSI<T> Kilo = new UnitSI<T>(3, "k", "kilo");
        public static UnitSI<T> Mega = new UnitSI<T>(6, "M", "mega");
        public static UnitSI<T> Giga = new UnitSI<T>(9, "G", "giga");
        public static UnitSI<T> Tera = new UnitSI<T>(12, "T", "tera");
        public static UnitSI<T> Peta = new UnitSI<T>(15, "P", "peta");
        public static UnitSI<T> Exa = new UnitSI<T>(18, "E", "exa");
        public static UnitSI<T> Zetta = new UnitSI<T>(21, "Z", "zetta");
        public static UnitSI<T> Yotta = new UnitSI<T>(24, "Y", "yotta");
    }
}
