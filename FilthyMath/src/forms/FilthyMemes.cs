
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace FilthyMath
{
    /* FilthyMemes
     * An arbitrary memes form
     */
    public partial class FilthyMemes : Form
    {
        Image loader;
        float rot = 0;
        float incr = 50;
        float x = 4;
        float y = 4;

        List<Image> memes = new List<Image>();

        public FilthyMemes()
        {
            // Set icon from resource
            Icon = Properties.Resources.icon;
            
            InitializeComponent();

            // Set starting image
            loader = Properties.Resources.mtndew;
            pictureBox1.Image = loader;

            // Get all other memes (images) from resources
            ResourceSet resources = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, false, true);

            foreach (DictionaryEntry entry in resources)
            {
                String name = entry.Key.ToString();
                Object resource = entry.Value;
                Type type = resource.GetType();
                if (type.Equals(typeof(Bitmap)))
                    memes.Add((Image)resource);
            }
        }

        private void FilthyMemes_Load(object sender, EventArgs e)
        {
            // Failed attempt at transparency
            BackColor = Color.Black;
            TransparencyKey = Color.Black;

            // Fill screen with form
            Rectangle rect = Screen.FromControl(this).WorkingArea;
            Location = new Point(0, 0);
            Size = new Size(rect.Width, rect.Height);

            // Fill form with picturebox for drawing
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size(rect.Width, rect.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Move stuff and speed up
            rot += incr;
            incr += 0.1f;
            rot = rot % 360;
            pictureBox1.Image = Utils.RotateImage(memes[(int)rot * 10 % memes.Count], pictureBox1.Width, pictureBox1.Height, rot, x, y);
        }
    }
}
