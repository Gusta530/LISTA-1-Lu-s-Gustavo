/*Questão 10: Atualização de Pontos de Vida
* Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a
cada nível alcançado.
* Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.

@Lista: 01 - Lógica de Programação
@Autor: Luis Gustavo Serafim de Souza
@Data: 19/08/2024*/

using System;
using System.ComponentModel.DataAnnotations.Schema;
class Program
{
    static void Main(string[] args)
    {
        double vpvi, vaumN, vdna, pvf;

        System.Console.WriteLine("VALOR DOS SEUS PONTOS DE VIDA INICIAL");
        double.TryParse(Console.ReadLine(), out vpvi);

        System.Console.WriteLine("VALOR DE AUMENTO POR NIVEL");
        double.TryParse(Console.ReadLine(), out vaumN);
    
        System.Console.WriteLine("VALOR DO NIVEL ALCANÇADO");
        double.TryParse(Console.ReadLine(), out vdna);

        pvf = vpvi + vaumN * vdna;
        System.Console.WriteLine("PONTUAÇÃO FINAL: " + pvf);
        Console.ReadLine();       
    }
}