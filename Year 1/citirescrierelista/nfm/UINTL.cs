using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nfm
{
    public class UINTL
    {
        List<byte> digits;
        public UINTL() 
        {
            digits = new List<byte>(); 
        }

        public UINTL(string data) 
        {
            digits = new List<byte>();
            string[] tmp = data.Split(' ');
            foreach (string s in tmp)
            {
                try
                {
                    digits.Add(byte.Parse(s));
                }
                catch { }
            }

        }

        public void ADD(byte toAdd) 
        {
            digits.Add(toAdd);
        }



        public string view() 
        {
            string toR = "";
            foreach (byte b in digits) toR += b + " ";
            return toR;
        }
    }
}
