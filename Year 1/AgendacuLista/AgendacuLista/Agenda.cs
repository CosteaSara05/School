using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendacuLista
{
    class Agenda
    {
        public string nume;
        public string prenume;
        public string adresa;
        public string telefon;
        public string email;

        public string view()
        {
            return nume + " " + prenume + " " + adresa + " " + telefon + " " + email;
        }

        public Agenda(string a, string b, string c, string d, string e)
        {
            nume = a;
            prenume = b;
            adresa = c;
            telefon = d;
            email = e;
        }
        public static bool operator==(Agenda a,Agenda b)
        {
            return (a.nume==b.nume&&a.prenume==b.prenume?true:false);
        }
        public static bool operator !=(Agenda a, Agenda b)
        {
            return (a.nume == b.nume && a.prenume == b.prenume ? false : true);
        }
    }
}
