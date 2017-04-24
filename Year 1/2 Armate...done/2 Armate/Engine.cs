using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2_Armate
{
    public static class Engine
    {
        public static Graphics g;
        public static Bitmap b;
        public static Random r = new Random();
        public static Color bkColor = Color.ForestGreen;

        public static List<Unit> army1 = new List<Unit>();
        public static List<Unit> army2 = new List<Unit>();

        public static int resx;
        public static int resy;
        public static void battleWave(List<Unit> A, List<Unit> B)
        {
            if((A.Count != 0) && (B.Count != 0))
            foreach (Unit u in A)
            {
                int target = r.Next(B.Count);
                int lA = r.Next((int)u.AS) + 1;
                int lB = r.Next((int)B[target].DS) + 1;

                if (lA > lB)
                {
                    int lFp = r.Next((int)u.FP) + 1;
                    int lAr = r.Next((int)u.AR) + 1;
                    if (lFp > lAr)
                    {
                        B[target].HP -= lFp;
                        if (B[target].HP < 0)
                            B[target].isDead = true;
                    }
                }

            }
        }
    }
}
