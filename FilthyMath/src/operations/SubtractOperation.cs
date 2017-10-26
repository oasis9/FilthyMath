using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace FilthyMath
{
    class SubtractOperation : Operation
    {
        /* SubtractOperation
         * Object for storage of data regarding the subtract operation
         */
        internal SubtractOperation(int factorMinimum, int factorMaximum, MetroToggle toggle) : base("-", factorMinimum, factorMaximum, toggle)
        {
        }

        internal override float Perform(float factor1, float factor2)
        {
            return factor1 - factor2;
        }
    }
}
