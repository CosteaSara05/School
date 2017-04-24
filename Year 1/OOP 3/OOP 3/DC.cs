using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Exception
    {

    }
    enum ZileSaptamana
    {
        Luni,
        Marti,
        Miercuri,
        Joi,
        Vineri,
        Sambata,
        Duminica

    }
    struct DC
    {
        #region Private fields
        private int zi, luna, an;
        private int ora, minut, secunda;
        private bool valid;
        #endregion

        #region Public Properties
        //public int zi
        //{
        //    get
        //    {
        //        return zi;
        //    }

        //}
        //public int luna
        //{
        //    get
        //    {
        //        return luna;
        //    }

        //}
        //public int an
        //{
        //    get
        //    {
        //        return an;
        //    }

        //}
        //public int ora
        //{
        //    get
        //    {
        //        return ora;
        //    }

        //}
        //public int minut
        //{
        //    get
        //    {
        //        return minut;
        //    }

        //}
        //public int secunda
        //{
        //    get
        //    {
        //        return secunda;
        //    }

        //}
        #endregion

        #region Constructor
        public DC(int zi, int luna, int an, int ora, int minut, int secunda)
        {
            this.zi = zi;
            this.luna = luna;
            this.an = an;
            this.ora = ora;
            this.minut = minut;
            this.secunda = secunda;
            valid = true;
            validateDC();
        }

        private void validateDC()
        {
            //if (instructiunea este incorecta)
            //      valid = false;
        }

        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0:D2}", zi);
            sb.Append(".");
            sb.AppendFormat("{0:D2}", luna);
            sb.Append(".");
            sb.Append(an);
            sb.Append(" ");
            sb.AppendFormat("{0:D2}", ora);
            sb.Append(":");
            sb.AppendFormat("{0:D2}", minut);
            sb.Append(":");
            sb.AppendFormat("{0:D2}", secunda);
            return sb.ToString();
        }


    }
}
