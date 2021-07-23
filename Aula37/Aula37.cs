// Herança/Ordem de execução dos construtores - Curso Programação Completo C# - Aula 37

using System;

class Base{
    public Base(){
        Console.WriteLine("Contrutor da classe Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Contrutor da classe Derivada1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Contrutor da classe Derivada2");
    }
}
class Aula37{
    static void Main(){

        Derivada2 derivada2 = new Derivada2();

    }
}