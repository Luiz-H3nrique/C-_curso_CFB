// Loop DO WHILE / Estruturas de iteração - Curso Programação Completo C# - Aula 21
using System;
class Aula21{
    static void Main(){
    
    string senha = "123";
    String senhauser;
    int tentativas = 0 ;
   do{
       Console.Clear();
       Console.WriteLine("Digite a senha");
       senhauser = Console.ReadLine();
       tentativas++;
    } while(senha != senhauser);
        Console.Clear();
        Console.WriteLine("Senha Correta tentativas : "+ tentativas);
    }
}