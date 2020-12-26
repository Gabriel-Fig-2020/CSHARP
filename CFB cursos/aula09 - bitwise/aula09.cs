using System;

class Aula09 {

    static void Main() {

        int num  = 10;
        int num2;
        //numero 1 binario anda p/ direita
        //ou esquerda (dobro ou metade)
        num = num << 1;
        num2 = num >> 1;

        Console.WriteLine(num);
        Console.WriteLine("\n"+num2);

    }

}