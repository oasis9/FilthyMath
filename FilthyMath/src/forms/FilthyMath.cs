using FilthyMath.src.forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilthyMath
{
    /* FilthyMath
     * General menu preceeding math game
     */
    public partial class FilthyMath : MetroForm
    {
        internal const int factorRangeMinimum = -100;
        internal const int factorRangeMaximum = 100;
        internal const int factorRangeDefaultMinimum = 0;
        internal const int factorRangeDefaultMaximum = 50;

        public FilthyMath()
        {
            // Set icon from resource
            Icon = Properties.Resources.icon;

            InitializeComponent();

            // Initialise operations (they self-register)
            new AddOperation(0, 50, additionToggle);
            new SubtractOperation(0, 50, subtractionToggle);
            new MultiplyOperation(0, 12, multiplicationToggle);
            new DivideOperation(0, 50, divisionToggle);

            // Show help/about dialog and then bring into focus
            FilthyHelp help = new FilthyHelp();
            help.ShowDialog();
            Activate();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Mitigate drawing issues
            DoubleBuffered = true;
            base.OnLoad(e);
        }

        private void operationCheckedChanged(object sender, EventArgs e)
        {
            // Handle operation toggle and ensure that at least one toggle is always on
            // If one toggle is on and it is being turned off, turn all others on
            int checks = 0;
            foreach (Control ctrl in operationsGroupBox.Controls)
                if (ctrl is MetroToggle)
                {
                    MetroToggle mt = (MetroToggle)ctrl;
                    if (mt.Checked)
                        checks++;
                }

            MetroToggle mtsender = (MetroToggle)sender;
            if (!mtsender.Checked && checks < 1)
                foreach (Control ctrl in operationsGroupBox.Controls)
                    if (ctrl is MetroToggle)
                    {
                        MetroToggle mt = (MetroToggle)ctrl;
                        if (!mt.Equals(mtsender))
                            mt.Checked = true;
                    }
        }

        private void operationsMouseUp(object sender, MouseEventArgs e)
        {
            // If a toggle is right-clicked, toggle it and set all other toggles in group to inverse state
            if (e.Button == MouseButtons.Right)
            {
                MetroToggle mtsender = (MetroToggle)sender;
                mtsender.Checked = !mtsender.Checked;

                foreach (Control ctrl in operationsGroupBox.Controls)
                    if (ctrl is MetroToggle && !ctrl.Name.Equals(mtsender.Name))
                    {
                        MetroToggle mt = (MetroToggle)ctrl;
                        mt.Checked = !mtsender.Checked;
                    }
            }
        }

        private List<Operation> GetOperations()
        {
            List<Operation> operations = new List<Operation>();

            // Iterate all controls
            foreach (Control ctrl in operationsGroupBox.Controls)
                
                // Check if control is a toggle
                if (ctrl is MetroToggle)
                {
                    MetroToggle toggle = (MetroToggle)ctrl;

                    // A disabled toggle means a disabled operation - No further action req'd
                    if (!toggle.Checked)
                        continue;

                    // Iterate available operations
                    foreach (Operation operation in Operation.all)

                        // Check if that operation's toggle matches the current iteration toggle
                        if (operation.Toggle.Equals(toggle))
                        {

                            // Add operation to list for its toggle is assigned and enabled
                            operations.Add(operation);
                            break;
                        }
                }

            return operations;
        }

        private void questionsNumeric_ValueChanged(object sender, EventArgs e)
        {
            questionsLabel.Text = "question" + (questionsNumeric.Value == 1 ? "" : "s");
        }

        private void Start()
        {
            // Pre-game starting logic
            string username = usernameText.Text;
            int questions = (int)questionsNumeric.Value;
            List<Operation> operations = GetOperations();

            if (username.Equals(""))
                // Name not set
                FilthyMessage.Show("You need to type a name!");
            else
            {
                // Start game
                Hide();

                FilthyGame game = new FilthyGame(username, questions, operations);
                game.ShowDialog();

                // Return to menu
                Show();
                Activate();
            }
        }

        private void FilthyMath_KeyDown(object sender, KeyEventArgs e)
        {
            // Detect enter/return key, suppress to prevent sound, and attempt to start game
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = e.SuppressKeyPress = true;
                Start();
            }
        }

        private void operationsOptionsButton_Click(object sender, EventArgs e)
        {
            Operation.Modify(Operation.all);
        }

        private void additionOptionsButton_Click(object sender, EventArgs e)
        {
            Operation.Modify(Operation.GetByIdentifier("+"));
        }

        private void subtractionOptionsButton_Click(object sender, EventArgs e)
        {
            Operation.Modify(Operation.GetByIdentifier("-"));
        }

        private void multiplicationOptionsButton_Click(object sender, EventArgs e)
        {
            Operation.Modify(Operation.GetByIdentifier("x"));
        }

        private void divisionOptionsButton_Click(object sender, EventArgs e)
        {
            Operation.Modify(Operation.GetByIdentifier("/"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FilthyMath_Shown(object sender, EventArgs e)
        {
            Activate();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Hide();

            FilthyHelp help = new FilthyHelp();
            help.ShowDialog();

            Show();
            Activate();
        }
    }
}
