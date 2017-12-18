using NUnit.Framework;
using ProyectoBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancarioTestStub
{
    [TestFixture]
    public class CuentaBancariaStub
    {
        private CuentaBancaria cBanco;

        [Test]
        public void IngresoStub()
        {

            var log = new LogNuloConResultado(false);
            cBanco = new CuentaBancaria(log) { Balance = 100 };
            cBanco.Ingreso(100);
            Assert.That(cBanco.Balance, Is.EqualTo(200));
        }
    }
}
