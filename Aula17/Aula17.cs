using System;
class Aula17
{
    static void Main(){
        int n1,n2,n3,n4,n5;

        // Formas de declarar um array
        int[] n = new int[5];
        int [] num = new int[3]{55,77,99}; 
        int [] num1 ={55,77,99,66,88};


        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3]= 44;
        n[4] = 55;

        Console.WriteLine(num[2]);
    }
}