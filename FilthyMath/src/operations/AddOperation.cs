using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace FilthyMath
{
    /* AddOperation
     * Object for storage of data regarding the add operation
     */
    class AddOperation : Operation
    {
        internal AddOperation(int factorMinimum, int factorMaximum, MetroToggle toggle) : base("+", factorMinimum, factorMaximum, toggle)
        {
        }

        internal override float Perform(float factor1, float factor2)
        {
            return factor1 + factor2;
        }
    }
}
