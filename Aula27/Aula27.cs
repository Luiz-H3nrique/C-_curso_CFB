// Argumento params - Curso Programação Completo C# - Aula 27
using System ;
class Aula27{
    static void Main(){
        soma(10,5,2,4,7,5,7,1,2,3,20,100);

    }

    static void soma(params int[]n){
        int res = 0;

        if(n.Length < 1){
            Console.WriteLine("Não existem valores a serem somados");
        }else if(n.Length < 2){
            Console.WriteLine("Valores insuficientes para soma : {0}" , n[0]);
        }else{
            for(int i = 0 ; i < n.Length ; i++){
                res += n[i];
            }
            Console.WriteLine("A Soma dos Valores é : {0}",res);
        }

        
    }
}