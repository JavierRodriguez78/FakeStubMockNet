using Moq;
using NUnit.Framework;
using ProyectoBancario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancarioTest
{
    [TestFixture]
    public class CuentaBancariaTests
    {
        private CuentaBancaria cBank;


        [Test]
        public void IngresoTest()
        {
            var log = new Mock<ILog>();
            cBank = new CuentaBancaria(log.Object) {Balance = 100};
            cBank.Ingreso(100);

            Assert.That(cBank.Balance, Is.EqualTo(200));
        }
    }
}
