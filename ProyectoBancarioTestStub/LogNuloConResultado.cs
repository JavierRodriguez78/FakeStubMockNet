using ProyectoBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancarioTestStub
{
    class LogNuloConResultado : ILog
    {
        private bool resultadoEsperado;
        public LogNuloConResultado(bool resultadoEsperado)
        {
            this.resultadoEsperado = resultadoEsperado;
        }
        public bool write(String msg)
        {
            return resultadoEsperado;
        }
    }
}
