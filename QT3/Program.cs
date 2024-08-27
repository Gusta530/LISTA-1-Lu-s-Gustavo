/*Questão 3: Cálculo de Vida Restante
* Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
* Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Luis Gustavo Serafim de Souza
@Data: 19/08/2024*/

using System;
using System.Runtime.ConstrainedExecution;
class Program
{
    static void Main(string[] args)
{
    double VVI, VDR, VBR, VME, VMH, fim;

    System.Console.WriteLine("VALOR DA VIDA INICIAL");
    double.TryParse(Console.ReadLine(), out VVI);

    System.Console.WriteLine("VALOR DO DANO RECEBIDO");
    double.TryParse(Console.ReadLine(), out VDR); 

    System.Console.WriteLine("VALOR DO BÔNUS DE RECUPERAÇÃO");
    double.TryParse(Console.ReadLine(), out VBR);

    System.Console.WriteLine("VALOR DO MODIFICADOR DE EQUIPAMENTOS");
    double.TryParse(Console.ReadLine(), out VME);

    System.Console.WriteLine("VALOR DO MODIFICADOR DE HABILIDADES");
    double.TryParse(Console.ReadLine(), out VMH);

    fim = (((VVI-VDR+VBR)*VDR*VME)*VVI*VMH);
    System.Console.WriteLine("PONTUAÇÃO FINAL:"+fim);
    Console.ReadLine();
    
}

}