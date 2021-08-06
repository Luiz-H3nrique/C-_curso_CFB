// Exceções - Try Catch Finally - P1 - Curso Programação Completo C# - Aula 52
using System;

class Aula52{
    static void Main(){
         int n1,n2,res;
        res = n1 = n2 = 0;

        n1 = 10 ;
        n2 = 0  ;

        try{
            res= n1/n2;
            Console.WriteLine("{0}/{1}={2}",n1,n2,res);
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}",e.Message);
             Console.WriteLine("EX: {0}",e.GetType());
        }
        

       
    }
}