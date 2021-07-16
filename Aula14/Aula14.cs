// IF aninhado - Curso Programação Completo C# - Aula 14
using System;
class Aula14
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
        
        

  // >= 60 - Aprovado
  // 59 e 40 - Recuperação
  //< 40 - Reprovado
        if(res >= 60){
                if(res >= 90){
                    if(res >=99){
                        resultado ="O aluno e um genio e foi aprovado";
                    }else{
                    resultado = "Aprovado Com louvor";
                    }
                }else{
                    resultado = "Aprovado";
                }
        }
        else {
           if(res >= 40){
               resultado = "Recuperação";
           } else{
               resultado = "Reprovado";
           }
        }
        Console.WriteLine(" Nota:{0} - Resultado: {1}",res,resultado);
    }
}