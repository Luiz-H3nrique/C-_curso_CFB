//Array de estruturas - Curso Programação Completo C# - Aula 45
using System;
struct  Carro{
    
     public String modelo;

     public String cor;

   

     public void info(){
       
        Console.WriteLine("Modelo : {0}",this.modelo);
        Console.WriteLine("Cor : {0}",this.cor);
         Console.WriteLine("-------------------------------------");
     }

     
 }

class Aula45{
    static void Main(){
        int[] numeros = new int[10];
         Carro[] carros = new Carro[4];
         
         carros[0].modelo = "HRv";
         carros[0].cor = "Prata";

         carros[1].modelo = "Golf";
         carros[1].cor = "Azul";

         carros[2].modelo = "Jatta";
         carros[2].cor = "Branco";

         carros[3].modelo = "Argo";
         carros[3].cor = "Preto";

        for(int i = 0 ; i <carros.Length;i++){
             carros[i].info();
        }

    }
}