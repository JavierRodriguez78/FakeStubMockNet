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
    public class ClienteTest
    {

        [Test]
        public void ClienteActivoTest()
        {
            var mock = new Mock<ICliente>();
            mock.Setup(cliente => cliente.estaActivo("123456")).Returns(true);
            mock.Setup(cliente => cliente.estaActivo("654321")).Returns(false);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(mock.Object.estaActivo("123456"));
                Assert.IsFalse(mock.Object.estaActivo("654321"));
            });
        }

    }
}
