using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASCIIEngine.Components;

namespace ASCIIEngine
{
    public class World
    {
        public List<GameObject> Objects =  new List<GameObject>();

        public int X;
        public int Y;

        public World(Vector2 size)
        {
            X = size.x;
            Y = size.y;

            Console.SetWindowSize(X, Y);      
        }

        public void AddObject(GameObject Object)
        {
            Objects.Add(Object);
        }

        public void RemoveObject(GameObject Object)
        {
            foreach (GameObject obj in Objects)
            {
                if (obj.Name == Object.Name)
                {
                    Objects.Remove(Object);
                    return;
                }
            }
        }

    }
}
