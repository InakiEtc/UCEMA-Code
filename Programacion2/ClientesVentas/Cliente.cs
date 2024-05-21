using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesVentas
{
    abstract class Cliente
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Descuento { get; set; }
        public List<Venta> Ventas { get; set; }

        public double GetMontoBruto()
        {
            double monto = 0;
            foreach (Venta v in Ventas)
            {
                monto += v.MontoBruto;
            }
            return monto;
        }

        public double GetMontoNeto()
        {
            double monto = 0;
            foreach (Venta v in Ventas)
            {
                monto += v.MontoNeto;
            }
            return monto;
        }

        public double GetDescuento()
        {
            return GetMontoBruto() - GetMontoNeto();
        }
    }
    

    class ClienteNacional : Cliente
    {  
        public ClienteNacional(int legajo, string nombre, string apellido)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Descuento = 0.25;
            Ventas = new List<Venta>();
        }
    }

    class ClienteInternacional : Cliente
    { 
        public ClienteInternacional(int legajo, string nombre, string apellido)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Descuento = 0.10;
            Ventas = new List<Venta>();
        }
    }
}
