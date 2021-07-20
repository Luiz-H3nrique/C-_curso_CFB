// Métodos - Curso Programação Completo C# - Aula 24
using System;
class Aula24
{
    static void Main(){

       int v1,v2,r;
       
        v1 = int.Parse(Console.ReadLine());
        v2 = int.Parse(Console.ReadLine());
          r =   soma(v1,v2);
          Console.WriteLine("A soma De {0} e {1} é: {2}",n1,n2,r);
        
    }

    static int soma(int n1,int n2){
        int res = n1 + n2 ;
        
       
        return res;
    }
}