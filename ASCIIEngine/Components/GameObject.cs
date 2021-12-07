using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIEngine.Components
{
    public class GameObject
    {
        public int x_pos = 0;
        public int y_pos = 0;

        public int x_size = 1;
        public int y_size = 1;

        public string Name = "gameObject";
        public string Tag = "object";

        public GameObject(Vector2 pos, Vector2 size)
        {
            x_pos = pos.x;
            y_pos = pos.y;

            x_size = size.x;
            y_size = size.y;
        }
    }
}
