using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixacaoConceitosBasicos1.Model;

namespace TestesFixacaoConceitosBasicos1
{
    [TestClass]
    public class TesteCalculaAumento
    {
        [TestMethod]
        public void TesteCalculoAumento()
        {
            #region Arrange
            double salario = 1000;
            double aumento = 0.1;
            #endregion Arrange

            double salarioAumentado = salario + (salario * aumento);
            Assert.AreEqual(CalculaAumento.Calcular(aumento, salario), salarioAumentado);
        }
    }
}
