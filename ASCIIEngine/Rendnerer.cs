using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ASCIIEngine.Components;

namespace ASCIIEngine
{
    class Rendnerer
    {
        int fps;

        string x_pixel;
        string y_pixel;
        string empty_pixel;

        World world;

        List<GameObject> objects = new List<GameObject>();

        public Rendnerer(World _world, int _fps)
        {
            fps = _fps;
            world = _world;

            x_pixel = Consts.X_PIXEL;
            y_pixel = Consts.Y_PIXEL;
            empty_pixel = Consts.EMPTY_PIXEL;

            objects = _world.Objects;

            Thread rednerer = new Thread(new ThreadStart(Render));
            rednerer.Start();
        }

        public void Render()
        {
            while (true)
            {
                foreach (GameObject Object in objects)
                {
                    int x_pos = Object.x_pos;
                    int y_pos = Object.y_pos;

                    int x_ver = Object.x_size;
                    int y_ver = Object.y_size;

                    for (int i = 0; i < y_pos; i++)
                    {
                        Console.WriteLine();
                    }

                    for (int i = 0; i < x_pos; i++)
                    {
                        Console.Write(empty_pixel);
                    }

                    for (int i = 0; i < x_ver; i++)
                    {
                        Console.Write(x_pixel);
                    }

                    for (int i = 0; i < y_ver; i++)
                    {
                        Console.WriteLine();

                        for (int o = 0; o < x_pos; o++)
                        {
                            Console.Write(empty_pixel);
                        }

                        Console.Write(y_pixel);

                        for (int x = 0; x < x_ver; x++)
                        {
                            Console.Write(empty_pixel);
                        }

                        Console.Write(y_pixel);
                    }

                    Console.WriteLine();

                    for (int i = 0; i < x_pos; i++)
                    {
                        Console.Write(empty_pixel);
                    }

                    for (int i = 0; i < x_ver; i++)
                    {
                        Console.Write(x_pixel);
                    }
                }


                Thread.Sleep(Convert.ToInt32(Consts.FPS));
                Console.Clear();
            }
        }
    }
}
