using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1 {

    public class Rettangolo
    {
        public int Base;
        public int Altezza;
        public int Perimetro;
        public int Area;


        public void StampaRettangolo()
        {
            Console.WriteLine("--Rettangolo--");
            Console.WriteLine("base: " + Base + " cm");
            Console.WriteLine("altezza: " + Altezza + " cm");
            Console.WriteLine("perimetro:" + Perimetro + " cm");
            Console.WriteLine("area: " + Area + " cm2");

           
        }
    }

    
}
