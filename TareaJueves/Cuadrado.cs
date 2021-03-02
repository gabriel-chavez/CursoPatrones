using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaJueves
{
    class Cuadrado:Rectangulo
    {
       
        public Cuadrado(int lado):base(lado,lado)
        {
            tipo = "Cuadrado";
        }
    }
}
