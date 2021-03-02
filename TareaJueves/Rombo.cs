using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaJueves
{
    class Rombo:Figura
    {
        int diagonal1;
        int diagonal2;

        public Rombo(int diagonal1, int diagonal2)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
            tipo = "Rombo";
        }

        public override double getArea()
        {
            double areaRombo = diagonal1 * diagonal2 / 2;
            Console.WriteLine("AREA ROMBO: " + areaRombo);
            return base.getArea();
        }

        public override void dibujar()
        {
            base.dibujar();
            Console.WriteLine("   **   ");
            Console.WriteLine(" ******");
            Console.WriteLine("********");
            Console.WriteLine(" ******");
            Console.WriteLine("   **   ");
            base.dibujar();
        }
    }
}
