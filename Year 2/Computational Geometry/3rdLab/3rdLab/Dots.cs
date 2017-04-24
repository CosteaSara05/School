using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _3rdLab
{
    public class Dot
    {
        public bool IsDrew;
        public Point Point;

        public Dot(bool IsDrew, Point Point)
        {
            this.IsDrew = IsDrew;
            this.Point = Point;
        }
    }
}
