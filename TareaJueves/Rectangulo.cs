using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaJueves
{
    public class Rectangulo : Figura
    {
        protected int base_;
        protected int altura;
        public Rectangulo(int b, int a)
        {
            base_ = b;
            altura = a;
            tipo = "Rectangulo";
        }


        public override double getArea()
        {
            return base_ * altura;
        }


        public override void dibujar()
        {
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < base_; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
