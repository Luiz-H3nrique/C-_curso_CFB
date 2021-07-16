//Comando condicional IF - Curso Programação Completo C# - Aula 12
using  System;
class Aula12
{
    static void Main(){
        int n1,n2,n3,n4,res ;

         res=n1=n2=n3=n4=0;
         Console.WriteLine("Digite a nota 1:");
         n1= int.Parse(Console.ReadLine());

          Console.WriteLine("Digite a nota 2:");
         n2= int.Parse(Console.ReadLine());

          Console.WriteLine("Digite a nota 3:");
         n3= int.Parse(Console.ReadLine());

          Console.WriteLine("Digite a nota 4:");
         n4= int.Parse(Console.ReadLine());

         res = n1+n2+n3+n4;
        string resultado ="Reprovado";
        
        


        if((res) >= 60){
                resultado = "Aprovado";
        }
        Console.WriteLine(" Nota:{0} Resultado: {1}",res,resultado);
    }
}