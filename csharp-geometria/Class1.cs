using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1 {

    public class Rettangolo
    {
        public int Baserettangolo;
        public int AltezzaRettangolo;
        public int PerimetroRettangolo;
        public int AreaRettangolo;


        public void StampaRettangolo()
        {
            Console.WriteLine("--Rettangolo--");
            Console.WriteLine("base: " + Baserettangolo + " cm");
            Console.WriteLine("altezza: " + AltezzaRettangolo + " cm");
            Console.WriteLine("perimetro:" + PerimetroRettangolo + " cm");
            Console.WriteLine("area: " + AreaRettangolo + " cm2");
        }
    }

    
}
