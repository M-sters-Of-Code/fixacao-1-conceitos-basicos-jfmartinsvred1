
//* A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
using System.Drawing;

namespace FixacaoConceitosBasicos1.Model
{
    public static class CalculaDesconto
    {
        public static string Calcular(double valor, double desconto)
        {
            var valorDesconto = valor*desconto;
            var valorFinal = valor-valorDesconto;
            return $"Valor Atual: {valor}\nPercentual de desconto: {desconto*100}% \nValo do desconto: {valorDesconto} \nValor Final: {valorFinal}";
        }

    }
}
