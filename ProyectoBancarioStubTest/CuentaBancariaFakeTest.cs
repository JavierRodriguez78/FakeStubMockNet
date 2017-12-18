using NUnit.Framework;
using ProyectoBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancarioStubTest
{
    [TestFixture]
    public class CuentaBancariaFakeTest
    {
        private CuentaBancaria cBanco;
        private LogNulo lNulo = new LogNulo();

        [Test]
        public void IngresoFakeTest()
        {
            cBanco = new CuentaBancaria(lNulo) { Balance = 100 };
            cBanco.Ingreso(100);
            Assert.That(cBanco.Balance, Is.EqualTo(200));
        }

    }
}
