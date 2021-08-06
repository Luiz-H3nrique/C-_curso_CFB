// Delegates - Curso Programação Completo C# - Aula 50
using System;

delegate int OP(int n1,int n2);
class Mat{
    public static int soma(int n1, int n2){
        return n1+n2;
    }

    public static int mult(int n1 , int n2){
        return n1*n2;
    }
}
class Aula50{
    static void Main(){
        int res;

        OP d1 = new OP(Mat.soma);

        res = d1(10,50);

        Console.WriteLine("Soma; {0} ",res);

        d1 = new OP(Mat.mult);

        res = d1(10,50);
        Console.WriteLine("Multiplicação : {0}",res);
    }
}