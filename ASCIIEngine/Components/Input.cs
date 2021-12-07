using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ASCIIEngine.Components
{
    public static class Input
    {
        public static char GetKey()
        {
            return Console.ReadKey().KeyChar;
        }
    }
}
