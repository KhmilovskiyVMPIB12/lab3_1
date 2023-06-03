using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratornayaRabota3
{
    internal class SprayBrush : Brush
    {

        public SprayBrush(Color BrushColor, int size) : base(BrushColor, size)
        {

        }



        public override void Draw(Bitmap image, int x, int y)
        {
            Random r = new Random();
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    int rNum = r.Next(1, 100);
                    if (rNum % 5 == 0)
                    {
                        if (x0 > 0 & y0 > 0 & x0 < W & y0 < H)
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }
                    }



                }

            }
        }
    }
}
