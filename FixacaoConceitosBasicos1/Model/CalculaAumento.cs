﻿
//A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
namespace FixacaoConceitosBasicos1.Model
{
    public static class CalculaAumento
    {
        public static double Calcular(double aumento, double salario)
        {
            var valorAumento = aumento* salario;
            var valorFinal = valorAumento + salario;

            return valorFinal;
        }
        //Crie o programa CalculaAumento que deve solicitar o valor atual do salário e o percentual de
        //aumento.Ao final deverá exibir todas as informações: salário inicial, percentual de aumento,
        //valor do aumento e valor do novo salário.
    }
}
