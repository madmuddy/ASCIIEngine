using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIEngine.Components
{
    public class Mesh
    {
        struct Pixels
        {
            public int x_size;
            public int y_size;
        }

        Pixels pixels;

        public Mesh(int x, int y)
        {
            pixels.x_size = x;
            pixels.y_size = y;
        }
    }
}
