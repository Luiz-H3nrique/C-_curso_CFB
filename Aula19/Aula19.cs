// Loop FOR / Estruturas de iteração - Curso Programação Completo C# - Aula 19
using System;
class Aula19{
    static void Main(){

        int[] num = new int [10];
        /*for(int num = 1;num <11;num++){ 

            Console.WriteLine("CFB Cursos " + num);

        }*/

        for (int i = 0; i<num.Length;i++){
            num[i]=i;
            Console.WriteLine(num[i]);
        }
        for(int i = 0;i<num.Length; i++){
            // num.length e utilizado para que o total de vezes impressas nao seja maior do que a matriz
            Console.WriteLine("Valor de num na pos{0}: {1}", i ,num[i]);
        }
    }

}