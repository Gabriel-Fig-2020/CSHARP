using System;

class Aula17 {
    static void Main(){
        int n1,n2,n3,n4,n5;
        int[] n=new int[5];
        int[] num=new int [3]{55,77,36};

        n[0]=10;
        n[1]=15;
        n[2]=16;
        n[3]=17;
        n[4]=19;

        Console.WriteLine(n[0]);
        for(int i=0; i<num.Length; i++){
            Console.Write("\n"+num[i]);
        }
    }
}