using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DeseneGeometrice
{
    class Engine
    {
        public static Random r = new Random();
        public static Graphics g;
        public static Bitmap b;
        public static List<Cerc> Ce = new List<Cerc>();
        public static List<Triunghi> Tr = new List<Triunghi>();
}
}
