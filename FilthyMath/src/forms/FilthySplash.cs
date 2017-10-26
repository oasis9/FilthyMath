using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilthyMath
{
    /* FilthySplash
     * Designated loading form
     */
    public partial class FilthySplash : Form
    {
        // Text array and index
        String[] text = {"Welcome to FilthyMath!", "Math is filthy.", "FilthyMath is loading.." };
        int index = 0;

        // Loading marquee animation variables
        int pos = 0; // Current animation position
        int speed = 15; // Movement speed
        int height = 5; // Height of gradient rect

        // Reference to background 'memegasm'
        FilthyMemes memes;

        public FilthySplash()
        {
            // Set icon from resource
            Icon = Properties.Resources.icon;

            InitializeComponent();

            // Set text change timer interval
            timer2.Interval = 2000;

            // Show background memes and keep reference for closing later
            memes = new FilthyMemes();
            memes.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Mitigate drawing issues
            this.DoubleBuffered = true;
            base.OnLoad(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update position for movement
            pos += speed;
            pos %= (int)(Width * 1.5);

            // Repaint
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Graphics object used for drawing
            Graphics gfx = e.Graphics;

            // The following code used to power a rainbow but the outcome was an eyesore, even if working.
            // The code is not being simplified simply so that modifications to color and sections can be made more easily in the future.
            // A more dynamic system could be written, however. Refactor!

            Rectangle beforeRect = new Rectangle(new Point(pos - Width / 2, 0), new Size(Width / 2, height));

            Point beforeStart = new Point(pos - Width / 2, 0);
            Point beforeEnd = new Point(pos, 0);
            LinearGradientBrush beforeBrush = new LinearGradientBrush(beforeStart, beforeEnd, Color.SeaGreen, Color.SeaGreen);
            gfx.FillRectangle(beforeBrush, beforeRect);


            Rectangle startRect = new Rectangle(new Point(pos, 0), new Size(Width / 2, height));
            startRect = startRect.X > Width ? new Rectangle(new Point(pos - (int)(Width * 1.5), 0), new Size(Width / 2, height)) : startRect;

            Point startStart = new Point(pos, 0);
            Point startEnd = new Point(pos + Width / 2, 0);
            LinearGradientBrush startBrush = new LinearGradientBrush(startStart, startEnd, Color.SeaGreen, BackColor);
            gfx.FillRectangle(startBrush, startRect);


            Rectangle endRect = new Rectangle(new Point(pos + Width / 2, 0), new Size(Width / 2, height));
            endRect = endRect.X > Width ? new Rectangle(new Point(pos - Width, 0), new Size(Width / 2, height)) : endRect;

            Point endStart = new Point(pos + Width / 2, 0);
            Point endEnd = new Point(pos + Width, 0);
            LinearGradientBrush endBrush = new LinearGradientBrush(endStart, endEnd, BackColor, Color.SeaGreen);
            gfx.FillRectangle(endBrush, endRect);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Any messages inbetween the first and last of the array will only show for half a second. This is intentional.
            timer2.Interval = 500;

            // Move to next string
            index++;
            // Outside array bounds
            if (index >= text.Length)
            {
                // Close memes and this form, allowing application to proceed (as defined in Program.cs)
                memes.Close();
                Close();
            }
            // Last item in array
            else if (index == text.Length - 1)
            {
                // Show messaege for a little longer
                timer2.Interval = 2000;
                label1.Text = text[index];
            }
            // Otherwise if neither condition is met, just show the next message.
            else
                label1.Text = text[index];
        }

        private void FilthySplash_Shown(object sender, EventArgs e)
        {
            Activate(); // Bring into focus
        }
    }
}
