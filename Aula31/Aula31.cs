// Classes static - Curso Programação Completo C# - Aula 31

using System;

 static public class Jogador{
      static public int energia;
     static public bool vivo ;

      static public string nome;

    // contrutor 
    static public void  iniciar(string n){
          energia = 100;
          vivo = true ;
          nome = n;
          
      }
     
      static public void info (){
          Console.WriteLine("Nome do Jogador ......:{0}",nome);
          Console.WriteLine("Energia do Jogador ......:{0}",energia);
          Console.WriteLine("Estado  do Jogador ......:{0}\n",vivo);

      }
 }

 class Inimigo{
    static public bool alerta;
     public string nome;

     public Inimigo (string n){
         alerta = false;
         nome = n;
     }
     public void info(){
         Console.WriteLine(nome);
         Console.WriteLine(alerta);
         Console.WriteLine("-----------------------------------------------------------------");
     }
 }

class Aula31{
    static void Main(){


  
      

      Inimigo i1 = new Inimigo("Doido");
      Inimigo i2 = new Inimigo("Maluco");
      Inimigo i3 = new Inimigo("Pirado");

    Inimigo.alerta = true;
      
      i1.info();
      i2.info();
      i3.info();

      
      

    }

    
   
}