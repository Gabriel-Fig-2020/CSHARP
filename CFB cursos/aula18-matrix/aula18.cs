using System;

class Aula17 {
    static void Main(){
        int n1,n2,n3,n4,n5;
        int[,] n=new int[3,5];

        n[0,0]=10;
        n[0,1]=15;
        n[0,2]=16;
        n[0,3]=17;
        n[0,4]=19;

        n[1,0]=10;
        n[1,1]=15;
        n[1,2]=16;
        n[1,3]=17;
        n[1,4]=19;

        n[2,0]=10;
        n[2,1]=15;
        n[2,2]=16;
        n[2,3]=17;
        n[2,4]=19;

        // Console.WriteLine(n[0]);
        for(int i=0; i<3; i++){
            Console.Write("\n");
            for(int j=0;j<5; j++){
                Console.Write(" "+n[i,j]);
            }
        }
    }
}