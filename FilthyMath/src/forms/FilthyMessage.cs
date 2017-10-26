using MetroFramework;
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
    /* FilthyMessage
     * A botched, dynamic, metro-enabled MessageBox API
     */
    public partial class FilthyMessage : MetroForm
    {
        private FilthyMessage()
        {
            // Set icon from resource
            Icon = Properties.Resources.icon;
            
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Exit
            Close();
        }

        internal static void Show(MetroColorStyle highlight, string message, string explanation)
        {
            // Global method for showing with color, message, and explanation
            FilthyMessage box = new FilthyMessage();
            box.Style = highlight;
            box.okButton.Style = highlight;
            box.messageLabel.Text = message;
            box.smallMessageLabel.Text = explanation;

            int labelWidth = Math.Max(box.messageLabel.Width, box.smallMessageLabel.Width);

            box.Size = new Size(labelWidth + 46, box.messageLabel.Height + box.smallMessageLabel.Height + 89);
            box.okButton.Location = new Point(box.Width / 2 - box.okButton.Width / 2, box.Height - box.okButton.Height / 2 - 33);
            box.ShowDialog();
        }

        internal static void Show(MetroColorStyle highlight, string message)
        {
            // Global method for showing with color and simple message
            Show(highlight, message, "");
        }

        internal static void Show(string message)
        {
            // Global method for showing with simple message
            Show(MetroColorStyle.Silver, message);
        }

        internal static void Show(string message, string explanation)
        {
            // Global method for showing with message and explanation
            Show(MetroColorStyle.Silver, message, explanation);
        }

        private void FilthyMessage_Shown(object sender, EventArgs e)
        {
            // Bring into focus
            Activate();
        }
    }
}
