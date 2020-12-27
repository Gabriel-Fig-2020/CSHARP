using System;

class Aula17 {
    static void Main(){
        int n1,n2,n3,n4,n5;
        int[,] n=new int[3,5];

        
        // Console.WriteLine(n[0]);
        for(int i=0; i<3; i++){
            for(int j=0;j<5; j++){
                n[i,j]= i + j;
            }
        }
        // Console.WriteLine(n[0]);
        for(int i=0; i<3; i++){
            Console.Write("\n");
            for(int j=0;j<5; j++){
                Console.Write(" "+n[i,j]);
            }
        }
    }
}