using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilthyMath
{
    /* Utils
     * General-purpose stateless utilities for use in multiple environments where state
     */
    class Utils
    {
        public static Image RotateImage(Image img, int width, int height, float rotationAngle, float x, float y)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics gfx = Graphics.FromImage(bmp);
            
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)bmp.Width / 2 + width / x, -(float)bmp.Height / 2 + height / y);
            
            gfx.InterpolationMode = InterpolationMode.HighQualityBilinear;
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            
            return bmp;
        }
    }
}
