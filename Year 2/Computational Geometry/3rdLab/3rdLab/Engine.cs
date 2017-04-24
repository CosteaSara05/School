using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3rdLab
{
    public class Engine
    {
        public static Random r = new Random();
        public static Graphics g;
        public static Bitmap b;
        public static List<Point> Points = new List<Point>();
        public static List<Dot> Dots = new List<Dot>();
        public static List<Point> choosenPoints = new List<Point>();
        public static List<Dot> choosenDots = new List<Dot>();
    }
}
