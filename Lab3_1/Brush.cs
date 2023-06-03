using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratornayaRabota3
{   
    abstract class Brush
    {
        public static int W, H;
        public Color BrushColor { get; set; }
        public int Size { get; set; }
        public Brush(Color brushColor, int size)
        {
            BrushColor = brushColor;
            Size = size;
        }
        public abstract void Draw(Bitmap image, int x, int y);
    }
}
