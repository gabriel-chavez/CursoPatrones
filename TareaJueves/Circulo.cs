using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaJueves
{
    class Circulo : Figura
    {
        int radio;


        public Circulo(int radio)
        {
            this.radio = radio;
            tipo = "Circulo";
        }



        public override double getArea()
        {
            return radio * radio * Math.PI;
        }


        public override void dibujar()
        {
            Console.WriteLine("   **   ");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("   **   ");
        }
    }
}
