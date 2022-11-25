using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        public string nomeRettangolo;
        public int baseRettangolo;
        public int altezzaRettangolo;

        public int CalcolaPerimetro() {
            int perimetro=baseRettangolo*2 + altezzaRettangolo*2;
            return perimetro;
        }
        public int CalcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("----------" + nomeRettangolo + "----------");
            Console.WriteLine();
            Console.WriteLine("Base: " + baseRettangolo + " cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: " + CalcolaPerimetro() + " cm");
            Console.WriteLine("Area: " + CalcolaArea() + " cm2");
        }

        public void DisegnaRettangolo()
            
        {
            string rettangolo = " ";
            for (int i=0; i<baseRettangolo; i++)
            {
                rettangolo += "--";
            }
            rettangolo += "\n";
            for (int i=0; i < altezzaRettangolo; i++)
            {
                rettangolo += "|";
                for (int j = 0; j < baseRettangolo; j++) 
                { 
                    rettangolo += "  ";
                }
               rettangolo +=("|\n");
            }
            rettangolo += " ";
            for (int i = 0; i < baseRettangolo; i++)
            {
                rettangolo += "--";
            }
            Console.WriteLine(rettangolo);

        }
    }
}
