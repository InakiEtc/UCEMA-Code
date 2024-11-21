using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjReflection3
{
    internal class Calculadora
    {     
        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            if (numero2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
            else
            {
                return numero1 / numero2;
            }
        }

    }
}
