using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3._11._2017
{
    public static class Engine
    {
        public static int resx;
        public static int resy;
        public static Bitmap bmp;
        public static Graphics g;
        public static int NOP;
        public static int crtTime = 0;
        public static Random rnd = new Random();
        public static List<Particle> Particles = new List<Particle>();
        public static List<PradatorParticle> Pradatorii = new List<PradatorParticle>();
        public static List<PradatorParticle> CopiiiPradatorilor = new List<PradatorParticle>();
        public static List<Particle> ParticlesChilds = new List<Particle>();
        public static int nrMax = 10000;
        public static void Init(int x, int y)
        {
            resx = x;
            resy = y;
            bmp = new Bitmap(resx, resy);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.AliceBlue);
            
        }
         public static float Dist(float x, float y, float x1, float y1)
        {
            return (float)Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
        }
        public static void Time()
        {
            ParticlesChilds.Clear();
            CopiiiPradatorilor.Clear();
            foreach(Particle p in Particles)
            {
                p.destroy = p.Destroy();
                p.doubled = p.SaveIt();
            }

            foreach (PradatorParticle p in Pradatorii)
            {
                p.destroy = p.Destroy();
                p.doubled = p.SaveIt();
                p.needFood = p.NeedFood();
            } 

            if (Particles.Count> nrMax)
            {
                if (Particle.rExp > Particle.rDis)
                {
                    int t = Particle.rExp;
                    Particle.rExp = Particle.rDis;
                    Particle.rDis = t;
                }
            }
            else
            {
                if (Particle.rExp < Particle.rDis)
                {
                    int t = Particle.rExp;
                    Particle.rExp = Particle.rDis;
                    Particle.rDis = t;
                }
            }

            if (Pradatorii.Count > nrMax)
            {
                if (PradatorParticle.rExp > PradatorParticle.rDis)
                {
                    int t = PradatorParticle.rExp;
                    PradatorParticle.rExp = PradatorParticle.rDis;
                    PradatorParticle.rDis = t;
                }
            }
            else
            {
                if (PradatorParticle.rExp < PradatorParticle.rDis)
                {
                    int t = PradatorParticle.rExp;
                    PradatorParticle.rExp = PradatorParticle.rDis;
                    PradatorParticle.rDis = t;
                }
            }
            foreach (Particle p in Particles)
            {
                if(p.doubled)
                {
                    float newX;
                    float newY;
                    float alpha = (float)rnd.NextDouble() * (float)Math.PI * 2;
                    float d = rnd.Next(Particle.raza);
                    newX = p.x + d * (float)Math.Cos(alpha);
                    newY = p.y + d * (float)Math.Sin(alpha);
                    ParticlesChilds.Add(new Particle((int)newX, (int)newY));
                }
            }
            Particles=Particles.FindAll(delegate (Particle p) { return !p.destroy; });
            foreach (Particle p in ParticlesChilds)
            {
                Particles.Add(p);
            }

            foreach(PradatorParticle p in Pradatorii)
            {
                
                if(p.needFood)
                {
                    Particle target = Particles[0];
                    float dMin = Dist(p.x, p.y, target.x, target.y);
                    for (int i = 1; i < Particles.Count; i ++)
                    {
                        float d = Dist(p.x, p.y, Particles[i].x, Particles[i].y);
                        if(d<dMin)
                        {
                            target = Particles[i];
                            dMin = d;
                        }
                    }
                    if(dMin<PradatorParticle.raza)
                    {
                        target.destroy = true;
                    }
                    else
                    {
                        p.destroy = true;
                    }
                }
            }

            foreach (PradatorParticle p in Pradatorii)
            {
                if (p.doubled)
                {
                    float newX;
                    float newY;
                    float alpha = (float)rnd.NextDouble() * (float)Math.PI * 2;
                    float d = rnd.Next(PradatorParticle.raza);
                    newX = p.x + d * (float)Math.Cos(alpha);
                    newY = p.y + d * (float)Math.Sin(alpha);
                    CopiiiPradatorilor.Add(new PradatorParticle((int)newX, (int)newY));
                }
            }
            Pradatorii = Pradatorii.FindAll(delegate (PradatorParticle p) { return !p.destroy; });
            foreach (PradatorParticle p in CopiiiPradatorilor)
            {
                Pradatorii.Add(p);
            }

        }
        public static void InitSession( int n)
        {
            NOP = n;

            for (int i = 0; i <n ; i++)
            {
                Particles.Add(new Particle(rnd.Next(resx), rnd.Next(resy)));
                Pradatorii.Add(new PradatorParticle(rnd.Next(resx), rnd.Next(resy)));
            }

        }

        public static void DrawMap()
        {
            g.Clear(Color.AliceBlue);
            foreach(Particle p in Particles)
            {
                p.Draw();
            }
            foreach (PradatorParticle prad in Pradatorii)
            {
                prad.Draw();
            }
         
        }
    }
}
