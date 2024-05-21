using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesVentas
{
    public class Venta
    {
        public double MontoBruto { get; set; }
        public double MontoNeto { get; set; }

        public Venta(double montoBruto, double dto)
        {
            MontoBruto = montoBruto;
            MontoNeto =  montoBruto - ( montoBruto * dto);
        }
    }
}
