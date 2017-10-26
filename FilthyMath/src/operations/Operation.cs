using FilthyMath.src.forms;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilthyMath
{
    /* Operation
     * A class for handling and storing data and user customisation of mathematical operations
     */
    public abstract class Operation
    {
        internal readonly string Identifier; // +, -, x, /
        internal readonly MetroToggle Toggle; // toggle control on menu form

        // Defaults but settable via method SetRange
        private int factorMinimum = 0;
        private int factorMaximum = 50;

        // Readonly at internal level
        internal int FactorMinimum {
            get {
                return factorMinimum;
            }
        }
        internal int FactorMaximum
        {
            get {
                return factorMaximum;
            }
        }

        protected Operation(string identifier, int factorMinimum, int factorMaximum, MetroToggle toggle)
        {
            // Store operation information
            Identifier = identifier;
            this.factorMinimum = factorMinimum;
            this.factorMaximum = factorMaximum;
            Toggle = toggle;

            // Add operation to "all" list if it one of subtype doesn't already exist
            foreach (Operation operation in all)
                if (operation.GetType().Equals(GetType()))
                    return;

            all.Add(this);
        }

        internal abstract float Perform(float factor1, float factor2);

        internal void SetRange(int factorRange1, int factorRange2)
        {
            // Minimum is smaller, maximum is larger.
            factorMinimum = Math.Min(factorRange1, factorRange2);
            factorMaximum = Math.Max(factorRange1, factorRange2);
        }


        internal static List<Operation> all = new List<Operation>();

        internal static Operation GetByIdentifier(string identifier) // THERE'S NO THROWS KEYWORD - WHAT IS THIS BLASPHEMY?
        {
            // Search for Operation object by identifier string
            foreach (Operation operation in all)
                if (operation.Identifier.Equals(identifier))
                    return operation;

            // In this environment it's a better idea to provide a readable error now rather than later
            // A try/catch could be used to catch the error if desired
            throw new Exception("Invalid Operation identifier!");
        }

        internal static void Modify(List<Operation> operations)
        {
            // Show form for modification of a list of Operations
            FilthyOperation operationOptions = new FilthyOperation(operations, FilthyMath.factorRangeMinimum, FilthyMath.factorRangeMaximum);

            // Set data to defaults because we can't take data from any specific operation
            operationOptions.factorRange1Numeric.Value = FilthyMath.factorRangeDefaultMinimum;
            operationOptions.factorRange2Numeric.Value = FilthyMath.factorRangeDefaultMaximum;

            operationOptions.ShowDialog();
            if (operationOptions.exitCode != 0)
                // Cancelled or 'errored'
                return;

            // Modify operations
            foreach (Operation operation in operations)
                operation.SetRange((int)operationOptions.factorRange1Numeric.Value, (int)operationOptions.factorRange2Numeric.Value);
        }

        internal static void Modify(Operation operation)
        {
            // Show form for modification of a specific Operation
            FilthyOperation operationOptions = new FilthyOperation(new List<Operation>() { operation }, FilthyMath.factorRangeMinimum, FilthyMath.factorRangeMaximum);

            // Set data to operation values
            operationOptions.factorRange1Numeric.Value = operation.FactorMinimum;
            operationOptions.factorRange2Numeric.Value = operation.FactorMaximum;
            
            operationOptions.ShowDialog();
            if (operationOptions.exitCode != 0)
                // Cancelled or 'errored'
                return;

            // Modify operation
            operation.SetRange((int)operationOptions.factorRange1Numeric.Value, (int)operationOptions.factorRange2Numeric.Value);
        }
    }
}
