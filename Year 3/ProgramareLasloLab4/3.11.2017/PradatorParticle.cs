using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3._11._2017
{
    public class PradatorParticle
    {
        public float x, y;
        public static int Food = 50;
        public static int rExp = 5;
        public static int rDis = 3;
        public static int raza = 50;
        public bool destroy = false;
        public bool doubled = false;
        public bool needFood=false;
        public PradatorParticle(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public void Draw()
        {

            Engine.g.DrawEllipse(Pens.Red, x, y, 2, 2);
        }

        public bool Destroy()
        {
            int t = Engine.rnd.Next(100);
            if (t < rDis)
            {
                return true;
            }
            return false;
        }

        public bool SaveIt()
        {
            int t = Engine.rnd.Next(100);
            if (t < rExp)
            {
                return true;
            }
            return false;
        }
         public bool NeedFood()
        {
            int t = Engine.rnd.Next(100);
            if (t < Food)
            {
                return true;
            }
            return false;
        }


    }
}
