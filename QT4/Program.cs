/*Questão 4: Somatório de Moedas
* Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
* Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: Luis Gustavo Serafim de Souza
@Data: 19/08/2024*/

using System;
class Program
{
    static void Main(string[] args)
    {

        double V1M, V2M, V3M, V4M, V5M, fim;

        System.Console.WriteLine("O VALOR DA PRIMEIRA MOEDA");
        double.TryParse(Console.ReadLine(), out V1M);

        System.Console.WriteLine("O VALOR DA SEGUNDA MOEDA");
        double.TryParse(Console.ReadLine(), out V2M);

        System.Console.WriteLine("O VALOR DA TERCEIRA MOEDA");
        double.TryParse(Console.ReadLine(), out V3M);

        System.Console.WriteLine("O VALOR DA QUARTA MOEDA");
        double.TryParse(Console.ReadLine(), out V4M);

        System.Console.WriteLine("O VALOR DA QUINTA MOEDA");
        double.TryParse(Console.ReadLine(), out V5M);

        fim = (V1M+ V2M + V3M + V4M + V5M);
        System.Console.WriteLine("PONTUAÇÃO FINAL: "+ fim);
        Console.ReadLine();
    
    }
}