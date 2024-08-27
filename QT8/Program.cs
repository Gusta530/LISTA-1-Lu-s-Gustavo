/*Questão 8: Cálculo de Pontos de Habilidade
* Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser
distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
* Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade
atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.
* Quadro de Testes:

@Lista: 01 - Lógica de Programação
@Autor: Luis Gustavo Serafim de Souza
@Data: 19/08/2024*/

using System;
class Program

{
    public static void Main(string[] args)
    {
      double nfor, nagi, nint, ndes, nvit, total, fINAL;
      
      System.Console.WriteLine("DIGA O SEU NIVEL DE FORÇA");
      double.TryParse(Console.ReadLine(), out nfor);

      System.Console.WriteLine("DIGA O SEU NIVEL DE AGILIDADE");
      double.TryParse(Console.ReadLine(), out nagi);

      System.Console.WriteLine("DIGA O SEU NIVEL DE INTELIGENCIA");
      double.TryParse(Console.ReadLine(), out nint);

      System.Console.WriteLine("DIGA O SEU NIVEL DE DESTREZA");
      double.TryParse(Console.ReadLine(), out ndes);

      System.Console.WriteLine("DIGA O SEU NIVEL DE VITALIDADE");
      double.TryParse(Console.ReadLine(), out nvit);

      total = nfor + nagi + nint + ndes + nvit ;
      fINAL = total;

      System.Console.WriteLine("O TOTAL DE PONTOS É DE:" + fINAL);
      System.Console.WriteLine("APERTE ENTER PARA SAIR");

      Console.ReadLine();
    }
}
