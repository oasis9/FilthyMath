using FilthyMath.src.forms;
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

namespace FilthyMath
{
    /* FilthyGame
     * Game provider form
     */
    public partial class FilthyGame : MetroForm
    {
        // Information unchanging as of game start
        readonly string username;
        readonly List<Operation> operations;
        readonly int questions;
        
        // State data
        int question = 0;
        int correct = 0;

        // Current question data
        Operation operation;
        int factor1 = 0;
        int factor2 = 0;

        public FilthyGame(string username, int questions, List<Operation> operations)
        {
            // Set readonly fields
            this.username = username;
            this.questions = questions;
            this.operations = operations;

            // Set icon from resource
            Icon = Properties.Resources.icon;

            InitializeComponent();

            // Set question-related information and await input
            promptLabel.Text = username + ", type the answer then press Enter.";
            AskQuestion();
        }

        private void AskQuestion()
        {
            // Check how many questions have already been answered out of desired total
            if (question >= questions)
            {
                // Notify of game end and close
                FilthyMessage.Show("Well done! You got " + correct + " out of " + questions + " questions correct.");
                Close();
            }

            // Next question
            question++;
            
            Random rand = new Random();

            // Set label text and invalidate to enforce redraw
            answerText.Text = "";
            Text = "Question " + question;
            Invalidate();

            // Generate factors for new question, ensuring the answer is not decimal (43 / 52 = 0.8269230769230769, for instance)
            operation = operations[rand.Next(operations.Count)];

            int factorMinimum = operation.FactorMinimum;
            int factorMaximum = operation.FactorMaximum;

            float answer = 0;
            do // Do this stuff and repeat if the condition below is met
            {
                // Generate factors and store in type-instance scope variables
                factor1 = rand.Next(factorMinimum, factorMaximum);
                factor2 = rand.Next(factorMinimum, factorMaximum);
                answer = operation.Perform(factor1, factor2); // Use a method to apply the operation rather than a switch or similar. This is nice.
            } while (answer % 1 != 0); // Remainder when divided by 1 greater than zero will cause this loop to repeat until a non-decimal answer is found.

            // Show the question
            questionLabel.Text = factor1 + " " + operation.Identifier + " " + factor2;
        }

        private void CheckAnswer()
        {
            // Hide the "press the enter key" text
            promptLabel.Hide();
            
            try
            {
                // Evaluate answer
                if (float.Parse(answerText.Text).Equals(operation.Perform(factor1, factor2)))
                {
                    // Correct answer
                    TemporaryTitleColor(MetroColorStyle.Green);
                    correct++;
                }
                else
                {
                    // Incorrect answer
                    TemporaryTitleColor(MetroColorStyle.Red);
                }
                // Ask next question or exit
                AskQuestion();
            }
            catch
            {
                // Respond to an invalid input
                FilthyMessage.Show("That's not a real number!");
            }
        }

        private void Answer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                // Handle and suppress keypress
                e.Handled = e.SuppressKeyPress = true; // Assignment to multiple variables in a single statement is beautiful

                // Determine validity and correctness of answer
                CheckAnswer();
            }
        }

        private void TemporaryTitleColor(MetroColorStyle color)
        {
            Style = color; // Set title color
            Invalidate(); // Redraw
            
            colorTimer.Stop(); // Reset timer counter to prevent any overlap in previous recent method calls
            colorTimer.Start();
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            Style = MetroColorStyle.Silver; // Reset title color
            Invalidate(); // Redraw

            colorTimer.Stop();
        }

        private void FilthyGame_Shown(object sender, EventArgs e)
        {
            Activate(); // Bring into focus
        }
    }
}
