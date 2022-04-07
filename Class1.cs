using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
internal  class Rettangolo
{
        private int baseRettangolo;

        private int altezzaRettangolo;
    

        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
{
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
}
public void calcolaArea()
        {
            Console.WriteLine("L'area è");
            calcolaArea = (baseRettangolo * altezzaRettangolo);
        }

        public void calcolaPerimetro()
        {
            Console.WriteLine("Il perimetro è");
            calcolaPerimetro = baseRettangolo + altezzaRettangolo;
        }
        public void StampaRettangolo()
        {
            Console.WriteLine("Il perimetro è" + calcolaPerimetro);
            Console.WriteLine("L'area è" + calcolaArea);
        }
    }
}