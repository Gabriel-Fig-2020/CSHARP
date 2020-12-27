using System;

class Aula20{
    static void Main(){
        int[] num = new int[10];
        int x=0;
        while(x<10){
            num[x]=x;
            Console.Write("\n"+num[x]);
            x++;
        }

    }
}