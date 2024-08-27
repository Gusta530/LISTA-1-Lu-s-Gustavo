/*Questão 6: Conversão de Moeda do Jogo
* Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
cristais.
* Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: Luis Gustavo Serafim de Souza
@Data: 19/08/2024*/

using System;
class Program
{
    static void Main(string[] args)
    {
        double VM, VTC, VBE, VBH, fim;

        System.Console.WriteLine("O VALOR DA MOEDA");
        double.TryParse(Console.ReadLine(), out VM);

        System.Console.WriteLine("O VALOR DA TAXA DE CONVERSÃO");
        double.TryParse(Console.ReadLine(), out VTC);

        System.Console.WriteLine("O VALOR DO BÔNUS DE EVENTO");
        double.TryParse(Console.ReadLine(), out VBE);

        System.Console.WriteLine("O VALOR DO BÔNUS DE HABILIDADE");
        double.TryParse(Console.ReadLine(), out VBH);

        fim = ((VM / VTC)* VBE)* VBH;
        System.Console.WriteLine("PONTUAÇÃO FINAL: "+ fim);
        Console.ReadLine();
    }
}