- /*Questão 1: Informações do Personagem
* Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
* Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Luis Gustavo Serafim de Souza
@Data: 19/08/2024*/
using System;
class Programação
{
    static void Main(string[] args)
    {
    string? nm, idd, nvI, clas, ra;
    System.Console.WriteLine("Escreva seu nome de jogador");
    nm = Console.ReadLine();
    System.Console.WriteLine("Escreva sua idade");
    idd = Console.ReadLine();
    System.Console.WriteLine("Escreva seu nivel inicial do seu jogador");
    nvI = Console.ReadLine();         
    System.Console.WriteLine("Escreva sua classe");
    clas = Console.ReadLine();
    System.Console.WriteLine("Escreva a raça do jogador");
    ra = Console.ReadLine();
    System.Console.WriteLine("Nome: \n" + nm, "idade: \n" + idd,"nivel inicial: \n"+ nvI,"classe: \n"+clas, "raça: \n"+ ra);
    Console.ReadLine();
   
    }

}