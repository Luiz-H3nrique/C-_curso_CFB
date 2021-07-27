// Struct - Curso Programação Completo C# - Aula 44
using System;
 
 struct  Carro{
     public String marca;

     public String modelo;

     public String cor;

     public Carro(string marca , string modelo , string cor){
         this.marca = marca;
         this.modelo = modelo ;
         this.cor  = cor;
     }

     public void info(){
        Console.WriteLine("Marca : {0}",this.marca);
        Console.WriteLine("Modelo : {0}",this.modelo);
        Console.WriteLine("Cor : {0}",this.cor);
     }

     
 }
class Aula44{
    static void Main(){

    Carro c1  = new Carro("Honda","HRV", "Prata");
    Carro c2 = new Carro("VW", "Golf","Azul");

       c1.info();
       Console.WriteLine();
       c2.info();
       

    }
}