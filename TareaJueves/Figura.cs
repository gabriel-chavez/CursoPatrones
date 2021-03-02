using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaJueves
{
    public class Figura
    {        
        public string tipo { get; set; }

        public string toString()
        {
            return "***************** Figura{" +
                    "tipo='" + tipo + '\'' +
                    '}';
        }

        public virtual double getArea() { return -1; }

        public virtual void dibujar()
        {
            Console.WriteLine("+++");
        }

    }
}
