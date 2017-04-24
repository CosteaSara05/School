using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage_Classes
{
    public abstract class Auto
    {
        public static int loc;
        public static int totalval;
        public static int pasag;
        public static void Auto(int loc, int totalval, int pasag)
        {

        }
        public abstract void locuri();
        public abstract void valoare();
        public abstract void pasageri();
    }
    public class Car : Auto
    {
        public static int loc;
        public static int totalval;
        public static int pasag;

        public void Car(int loc, int totalval, int pasag) : base(int loc, int totalval, int pasag)
        {
            this.loc = loc;
        }

        public override void locuri()
        {
            loc = 1;
        }
        public override void valoare()
        {
            totalval = Engine.r.Next(1000, 50000);
        }
        public override void pasageri()
        {
            pasag = 5;
        }
    }
    public class Moto : Auto
    {
        public static int loc;
        public static int totalval;
        public static int pasag;
        
        public override void locuri()
        {
            loc = 1;
        }
        public override void valoare()
        {
            totalval = Engine.r.Next(100, 10000);
        }
        public override void pasageri()
        {
            pasag = 1;
        }

    }

}
