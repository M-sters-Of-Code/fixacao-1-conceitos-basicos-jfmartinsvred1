
//* - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
using System.Drawing;

namespace FixacaoConceitosBasicos1.Model
{
    public static class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            double valorDiaria = dias * 95;
            double valorKm = (quilometragemFinal - quilometragemInicial) * 0.35;
            return valorDiaria + valorKm;
        }
    }
}
