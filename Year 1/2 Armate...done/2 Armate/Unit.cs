using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _2_Armate
{
    public class Unit
    {
        public bool isDead;
        public static int drawSize; 
        public int x, y;
        public float AS, DS, AR, FP, HP;
        public Color fillcolor; 
        public Unit(float AS, float DS ,float AR, float FP, float HP, Color fillcolor)
        {
            this.AS = AS;
            this.DS = DS;
            this.AR = AR;
            this.FP = FP;
            this.HP = HP;
            isDead = false;
            this.fillcolor = fillcolor;
            x = Engine.r.Next(Engine.resx);
            y = Engine.r.Next(Engine.resy);
        }
        public void draw()
        {
            Engine.g.FillEllipse(new SolidBrush(fillcolor), x - drawSize, y - drawSize, 2 * drawSize, 2 * drawSize);
        }
        //public class Ofiter : Unit
        //{
        //    public Unit()
        //    {
        //        Unit.base();
        //    }
                
        //    public void draw()
        //    {
        //        Engine.g.FillEllipse(new SolidBrush(fillcolor), x - drawSize, y - drawSize, 2 * drawSize, 2 * drawSize);
        //    }
        //}
    }
}
