using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace FilthyMath
{
    class MultiplyOperation : Operation
    {
        /* MultiplyOperation
         * Object for storage of data regarding the multiply operation
         */
        internal MultiplyOperation(int factorMinimum, int factorMaximum, MetroToggle toggle) : base("x", factorMinimum, factorMaximum, toggle)
        {
        }

        internal override float Perform(float factor1, float factor2)
        {
            return factor1 * factor2;
        }
    }
}
