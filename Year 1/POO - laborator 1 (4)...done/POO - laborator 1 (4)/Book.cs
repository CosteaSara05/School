using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___laborator_1__4_
{
    public class Book
    {
        public string title;
        public string autor;
        public int an;
        public int pret;
        public string view()
        {
            return title + " " + autor;
        }
        public Book(string a, string b, string c, string d)
        {
            title = a;
            autor = b;
            an = int.Parse(c);
            pret = int.Parse(d);
        }
    }
}
