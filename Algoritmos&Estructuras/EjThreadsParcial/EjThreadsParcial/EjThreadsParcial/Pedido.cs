using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EjThreadsParcial
{
    public class Pedido
    {
        public int Id { get; set; }
        private Form1 Form;

        public Pedido(int id,Form1 form)
        {
            Id = id;
            this.Form = form;
        }

        public void enPreparacion()
        {
            Random random = new Random();
            int delay = random.Next(3000, 5000);
            Thread.Sleep(delay);
            Form.EncolarPedidoEmp(this);
        }

        public void enEmpaque()
        {
            Random random = new Random();
            int delay = random.Next(3000, 5000);
            Thread.Sleep(delay);
            Form.EncolarPedidoEnv(this);
        }

        public void enEnvio()
        {
            Random random = new Random();
            int delay = random.Next(1000, 3000);
            Thread.Sleep(delay);
            Form.MostrarPedido(this);
        }
    }
}
