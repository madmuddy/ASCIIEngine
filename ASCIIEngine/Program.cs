using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ASCIIEngine.Components;

namespace ASCIIEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World(new Vector2(120, 30));
            Rendnerer renderer = new Rendnerer(world, Consts.FPS);

            GameObject Object = new GameObject(new Vector2(10, 10), new Vector2(10, 10));

            world.AddObject(Object);

            while (true)
            {
                Thread.Sleep(Consts.FPS);

                if (Input.GetKey() == 'd')
                {
                    Object.x_pos += 5;
                }
                else if (Input.GetKey() == 'a')
                {
                    Object.x_pos -= 5;
                }
                else if (Input.GetKey() == 'w')
                {
                    Object.y_pos -= 5;
                }
                else if (Input.GetKey() == 's')
                {
                    Object.y_pos += 5;
                }
            }
        }
    }
}
