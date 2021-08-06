// Exceções - Try Catch Finally - P2 - Curso Programação Completo C# - Aula 53
using System;

class Area{
    public static float Quad(float bas, float alt){
        if(bas == 0 || alt == 0 ){
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
         return bas*alt;
    }
}
class Aula53{
    static void Main(){
         float are= 0;
       
        try{
           are = Area.Quad(0F,5F);
           Console.WriteLine("Area do quad: {0}",are);
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}",e.Message);
             
        }finally{
            Console.WriteLine("Fim do processo");
        }
        
    }
}