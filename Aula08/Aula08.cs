//Lendo valores do teclado - Curso Programação Completo C# - Aula 08
using System;
class Aula08{
    static void Main(){
        int v1 , v2,soma;
        string nome ;

        Console.Write("Digite o Primeiro valor : ");
        v1 = int.Parse(Console.ReadLine()); // converte string para parametro

        Console.Write("Digite o Segundo valor : ");
        v2 = Convert.ToInt32(Console.ReadLine()); // converte string para parametro
        soma = v1 + v2 ;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1,v2,soma);
    }
}