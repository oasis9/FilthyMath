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

namespace FilthyMath
{
    /* FilthyHelp
     * General information about application and copyrights
     */
    public partial class FilthyHelp : MetroForm
    {
        public FilthyHelp()
        {
            // Set icon from resource
            Icon = Properties.Resources.icon;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Mitigate drawing issues
            DoubleBuffered = true;
            base.OnLoad(e);
        }

        private void FilthyHelp_Shown(object sender, EventArgs e)
        {
            // Bring into focus
            Activate();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
