using System;

namespace OOP_2
{
    internal class ContBancar
    {
        private int sold;
        private string titular;
        private int contor;
        public ContBancar(string titular)
        {
            sold = 0;
            this.titular = titular;
        }

        //depune o suma de bani in cont.
        public void Depune(int v)
        {
            contor++;
            Console.WriteLine("#{1} - Depunere: {0}",v, contor);
            if (v >= 0)
            {
                sold += v;
                Console.WriteLine("Operatie reusita");
            }
            else
                Console.WriteLine("Operatie refuzata. Nu se pot depune sume negative.");
        }

        // retrage o suma de bani din cont.
        public void Retrage(int v)
        {
            contor++;
            Console.WriteLine("#{1} - Retrage: {0}", v, contor);
            if (v <= sold)
            {
                sold -= v;
                Console.WriteLine("Operatie reusita.");
            }
            else
                Console.WriteLine("Operatie refuzata. Fonduri insuficiente.");
        }
        public int Sold
        {
            get
            {
                contor++;
                Console.WriteLine("#{1} - Interogare sold",contor);
                return sold;
            }
        }
        public override string ToString()
        {
            return "Contul al carui titular este " + titular + " are soldul " + sold.ToString();
        }
    }
}