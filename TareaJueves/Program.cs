using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaJueves
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura rectangulo = new Rectangulo(3, 5);
            Figura circulo = new Circulo(4);
            Figura rombo = new Rombo(5, 4);

            List<Figura> figuras = new List<Figura>();
            figuras.Add(rectangulo);
            figuras.Add(circulo);
            figuras.Add(rombo);
            figuras.Add(new Cuadrado(4));

            foreach (Figura figura in figuras)
            {
                double area = figura.getArea();
                Console.WriteLine(figura.tipo + " tiene area de: " + area);
                figura.dibujar();
                Console.WriteLine("--------------------");
                Console.WriteLine(figura.toString());
            }

            Console.ReadLine();
        }
    }
}
