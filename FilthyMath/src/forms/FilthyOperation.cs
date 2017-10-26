using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilthyMath.src.forms
{
    /* FilthyOperation
     * Not to be confused with Operation, this is a form used to customise said type
     */
    public partial class FilthyOperation : MetroForm
    {
        // Unix style exit code. 0 is good, 1 is bad.
        internal int exitCode = 0;

        public FilthyOperation(List<Operation> operations, int factorMinimum, int factorMaximum)
        {
            // Construct operation list string
            string ops = "";
            foreach (Operation operation in operations)
                ops += (ops.Equals("") ? "" : ", ") + operation.Identifier;

            InitializeComponent();

            // Set title to operation list with prefix
            Text = "Options for " + ops;

            // Set icon from resource
            Icon = Properties.Resources.icon;

            Invalidate();

            // Set input bounds
            factorRange1Numeric.Maximum = factorMaximum;
            factorRange2Numeric.Maximum = factorMaximum;

            factorRange1Numeric.Minimum = factorMinimum;
            factorRange2Numeric.Minimum = factorMinimum;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Exit with OK
            exitCode = 0;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Exit with Cancelled or 'Error'
            exitCode = 1;
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            // Educational prank
            FilthyMessage.Show("Hah! Tricked you.", "Apply is useless in this situation since you won't see the effect until you close the window anyway.\nThere's no need to click Apply, OK does the same thing but also closes the window if you don't have any more changes to make.\n\nEver tried it? If it didn't work, try again.\nYou're definitely wrong, or using some really dodgy software.\n\nWhat's the difference between OK and Cancel? \"I'm okay with these changes, time to do something else.\"");
        }
    }
}
