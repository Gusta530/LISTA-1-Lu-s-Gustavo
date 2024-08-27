/*Questão 7: Cálculo de Nível do Jogador
* Contextualização: Um jogador ganha uma certa quantidade de experiência (XP) ao completar
missões. O nível do jogador é determinado pelo total de XP dividido por uma constante de nível
e ajustado por bônus.
* Comando: Crie um programa que receba a quantidade de XP acumulado, a constante de nível,
o bônus de nível, e dois multiplicadores (um para eventos especiais e outro para equipamentos),
e calcule o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: Luis Gustavo Serafim de Souza
@Data: 19/08/2024*/

using System;
class Program
{
    static void Main(string[] args)
    {
        double VXPA,XPPI,XPSI,VTI1,VTI2,QCN,fim;

        System.Console.WriteLine("O VALOR DE XP ACUMULADO");
        double.TryParse(Console.ReadLine(), out VXPA);

        System.Console.WriteLine("QUAL O XP CONCEDIDO PELO PRIMEIRO TIPO DE INIMIGO");
        double.TryParse(Console.ReadLine(), out XPPI);

        System.Console.WriteLine("QUAL O XP CONCEDIDO PELO SEGUNDO TIPO DE INIMIGO");
        double.TryParse(Console.ReadLine(), out XPSI);

        System.Console.WriteLine("QUAL O VALOR DE CADA TIPO DE INIMIGO DERROTADO 1?");
        double.TryParse(Console.ReadLine(), out VTI1);

        System.Console.WriteLine("QUAL O VALOR DE CADA TIPO DE INIMIGO DERROTADO 2?");
        double.TryParse(Console.ReadLine(), out VTI2);

        System.Console.WriteLine("QUAL A CONSTANTE DE NIVEL?: ");
        double.TryParse(Console.ReadLine(), out QCN);

        XPPI = XPPI * VTI1;
        XPSI = XPSI * VTI2;
        VXPA = XPPI + XPSI + VXPA;
        fim = VXPA/QCN;

        System.Console.WriteLine("o xp total é de: " + Math.Floor(VXPA));
        System.Console.WriteLine("o nível é de: "+ Math.Floor(fim));

        System.Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
        
    }
}