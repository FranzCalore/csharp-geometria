using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public int calcolaPerimetro() {
            int perimetro=baseRettangolo*2 + altezzaRettangolo*2;
            return perimetro;
        }
        public int calcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }
    }
}
