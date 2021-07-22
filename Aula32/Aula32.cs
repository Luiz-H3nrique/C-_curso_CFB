// This - Curso Programação Completo C# - Aula 32s

using System;

class Calculos{
    public int v1_1;
    public int v2_2 ;

    public Calculos (int v1 , int v2){
       this. v1_1 = v1;
        this.v2_2 = v2;

    }

    public int Somar(){
        return v1_1 + v2_2;
    }
}

class Aula32{
    static void Main(){

        Calculos c = new Calculos(10,2);

        Console.WriteLine(c.Somar());
    }
}