using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeLife.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Negocio.Tests
{
    [TestClass()]
    public class TarificadorTests
    {
        [TestMethod()]
        public void ClarecTest()
        {
            Tarificador tarifa = new Tarificador();
            try
            {
                tarifa.Clarec(17, 1, 2);
                return;
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Datos invalidos");
                return;
            }
            Assert.Fail("No se genero tarifa por datos invalidos");
        }
    }
}