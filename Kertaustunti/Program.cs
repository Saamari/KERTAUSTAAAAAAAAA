using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustunti
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo henkilo = new Henkilo();
            henkilo.Nimi = "MAtti  Knatterton";
            henkilo.Paino = 200;
            Console.WriteLine("Henkilön nimi on : " + henkilo.Nimi);
            Console.WriteLine("Henkilön paino on : " + henkilo.Paino);

            string nimi = "Merimies Niksu";
            double paino = 50;

            Henkilo henkilo2 = new Henkilo(nimi , paino);
            Console.WriteLine("Henkilön nimi on : " + henkilo2.Nimi);
            Console.WriteLine("Henkilön paino on : " + henkilo2.Paino);

            Henkilo henkilo3 = new Henkilo { Nimi = "Khulli", Paino = 11 };

            Katsoja katsoja = new Katsoja("Jaska",  100 ,  true);
            Console.WriteLine(katsoja.ToString());
            katsoja.huutaa();
            



        }
    }
}
