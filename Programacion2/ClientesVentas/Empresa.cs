using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesVentas
{
    public class Empresa
    {
        List<Cliente> clientes;

        public Empresa() 
        {
            clientes = new List<Cliente>();
        }

        public void AgregarCliente(object cliente)
        {
            clientes.Add(cliente as Cliente);
        }

        public void AsignarVenta(int legajo, double montoBruto)
        {
            Cliente c = clientes.Find(x => x.Legajo == legajo);
            if (c != null)
            {
                Venta v = new Venta(montoBruto, c.Descuento);
                c.Ventas.Add(v);
            }

        }

        public object GetClientes()
        {
            var cl = from c in clientes
                     select new { c.Legajo, c.Nombre, c.Apellido, MontoBruto = c.GetMontoBruto(), MontoNeto = c.GetMontoNeto(), Descuento = c.GetDescuento()};

            return cl.ToList();
        }

        internal Cliente Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
