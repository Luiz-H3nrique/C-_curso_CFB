// Passagem por valor e por referência - Curso Programação Completo C# - Aula 25
using System;

class Aula25
{
    static void Main(){
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);

    }

    static void dobrar(ref int valor){
        valor*=2; // dobra o valor

    }
}