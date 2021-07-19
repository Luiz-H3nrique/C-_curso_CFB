//Loop WHILE / Estruturas de iteraão - Curso Programação Completo C# - Aula 20
using System;
class Aula20{
    static void Main(){

         int[] num = new int [10];
       
        int i =0;
        /*while(i<10){
            
            Console.WriteLine("CFB Cursos");
            
            i++;
        }*/
         while(i<num.Length){
              // num.length e utilizado para que o total de vezes impressas nao seja maior do que a matriz
            num[i]=i;
            Console.WriteLine("CFB Cursos");
            
            i++;
        }
        Console.WriteLine("Fim do loop");

    }
}