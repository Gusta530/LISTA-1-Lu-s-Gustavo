/*Questão 5: Cálculo de Distância Percorrida
* Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
* Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: Luis Gustavo Serafim de Souza
@Data: 19/08/2024*/

using System;
class Program
{
    static void Main(string[] args)
    {

     double VVV, VTV, VCC, VEV, fim;

     System.Console.WriteLine("O VALOR DA VELOCIDADE DO VEICULO");
     double.TryParse(Console.ReadLine(), out VVV);

     System.Console.WriteLine("O VALOR DO TEMPO DE VIAGEM");
     double.TryParse(Console.ReadLine(), out VTV);

     System.Console.WriteLine("O VALOR DA CONDIÇÃO DO CLIMÁTICA");
     double.TryParse(Console.ReadLine(), out VCC);

     System.Console.WriteLine("O VALOR DO ESTADO DO VEÍCULO");
     double.TryParse(Console.ReadLine(), out VEV);

     fim = ((VVV*VTV)*VCC)*VEV;
     System.Console.WriteLine("PONTUAÇÃO FINAL: "+ fim);
     Console.ReadLine();
    }
}