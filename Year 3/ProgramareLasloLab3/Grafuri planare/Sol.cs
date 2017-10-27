using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafuri_planare
{
    public class Sol
    {
        PointF[] coord;
        public int ni;
        public Sol(bool fullRnd)
        {
            ni = 0;
            if (fullRnd)
            {
                coord = new PointF[Engine.nod];
                for (int i = 0; i < Engine.nod; i++)
                    coord[i] = Engine.rndPoint();
            }
            else
            {
                coord = new PointF[Engine.nod];
                float a = ((float)(Math.PI * 2)) / (float)Engine.nod;
                float l = 100;
                for(int i=0; i<Engine.nod; i++)
                {
                    coord[i].X = Engine.resx / 2 + l * (float)Math.Cos(i * a);
                    coord[i].Y = Engine.resy / 2 + l * (float)Math.Sin(i * a);
                }
            }
        }
        public void draw()
        {
            ni = 0;
            for(int i=0; i<Engine.nod; i++)
            {
                Engine.g.DrawEllipse(Pens.Red, coord[i].X - 4, coord[i].Y - 4, 8, 8);
            }
            for(int i=0; i<Engine.nod-1; i++)
            {
                for(int j=i+1; j < Engine.nod; j++)
                {
                    if (Engine.ma[i, j] == 1)
                    {
                        Engine.g.DrawLine(Pens.Red, coord[i], coord[j]);
                    }
                }
            }
            //optimizare

            for (int i = 0; i < Engine.nod - 1; i++) 
            {
                for (int j = i + 1; j < Engine.nod; j++)
                {
                    if(Engine.ma[i, j] == 1)
                    {
                        for (int l = 0; l < Engine.nod - 1; l++) 
                        {
                            for (int k = l + 1; k < Engine.nod; k++) 
                            {
                                if(Engine.ma[l, k] == 1)
                                {
                                    try
                                    {
                                        PointF tmp;
                                        if ((tmp = Engine.intersectie(coord[i], coord[j], coord[l], coord[k])) != PointF.Empty)
                                        {
                                            Engine.g.DrawEllipse(Pens.Blue, tmp.X - 2, tmp.Y - 2, 4, 4);
                                            ni++;
                                        }
                                    }
                                    catch { }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
