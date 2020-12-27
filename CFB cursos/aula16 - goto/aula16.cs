using System;
class Aula16{
    static void Main() {
        int tempo = 0;
        char escolha;
        inicio:
        Console.Clear();
        Console.WriteLine("BH/MG a Vitória/ES");
        Console.WriteLine("Escolha o Transporte:[a] | [c] | [o]");

        escolha=char.Parse(Console.ReadLine());

        switch(escolha) {
                case 'a':
                    tempo = 50;
                    break;
                
                case 'c':
                    tempo = 480;
                    break;
                
                case 'o':
                    tempo = 660;
                    break;
                
                default:
                    tempo = -1;
                    break;
        }

        if(tempo < 0) {
            Console.WriteLine("Transporte indisponivel");
        } else {
            Console.WriteLine("O tempo estimado de viagem é {0} minutos", tempo);
        }       
        Console.WriteLine("deseja outro transport? s ou n");
        escolha=char.Parse(Console.ReadLine());
        if(escolha =='s'){
            goto inicio;
        }else{Console.Clear();
        Console.WriteLine("FIM");}
    }
}