using System;

class Aula27{
    static void Main(){
        soma();
    }
    static void soma(params int[]n){
        int res = 0;
        if(n.Length < 1){
            Console.WriteLine("sem valores ");
        }else if(n.Length < 1) {
            Console.WriteLine("Valores insuficientes p soma");
        }else{
            for(int i=0; i<n.Length;i++){
                res+=n[i];
            }
            Console.WriteLine("soma: " + res);
        }        
    }
}