using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using IPlugin;

namespace InvertPlugin 
{
    public class Class1 : IPlugin.IPlugin
    {
        public string getName()
        {
            return "Invert";
        }

        public void run(Bitmap image)
        {
            Color c;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    c = image.GetPixel(i, j);
                    image.SetPixel(i, j,
                        Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
        }
    }
}
