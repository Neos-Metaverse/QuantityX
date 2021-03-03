/* *****************************************************************************
 * Author: Tomas "Frooxius" Mariancik (www.frooxius.com)
 * Date: 09/19/2014
 * 
 * Summary: Base for all SI units which are used by SI quantity types
 * *****************************************************************************/

using System;
using System.Collections.Generic;

using System;

namespace QuantityX
{
    public class UnitSI<T> : Unit<T> where T : IQuantitySI<T>
    {
        static UnitSI() { SIPower = default(T).SIPower; }
        static double SIPower;

        public UnitSI(int nFactor, string shortPrefix, string longPrefix) :
            base(Math.Pow(Math.Pow(10, nFactor), SIPower),
                new UnitGroup[] { UnitGroup.Metric },
                new string[] { " " + shortPrefix + "{0}" },
                new string[] { " " + longPrefix +  "{0}" })
        {
            if (nFactor % 3 == 0)
                UnitGroup.MetricThousands.RegisterUnit(this);
        }
    }

}
