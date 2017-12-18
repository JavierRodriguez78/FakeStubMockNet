using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancario
{
    public class CuentaBancaria
    {
        public int Balance { get; set; }
        private ILog log;

        public CuentaBancaria(ILog log)
        {
            this.log = log;
        }

        public void Ingreso(int cantidad)
        {
            log.write($"Usuario ha despositado {cantidad}");
            Balance += cantidad;
        }
    }
}
