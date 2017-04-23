using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa
{
    public class klaska1
    {
        public double Multipla(int x)
        {

            double liczba = x;
        fora:
            for (int i = x; i > 0; i--)
            {
                if (liczba % i != 0)
                {

                    liczba = liczba + x;
                    goto fora;
                }

            }
            
            return liczba;
           
        }
    }
}
