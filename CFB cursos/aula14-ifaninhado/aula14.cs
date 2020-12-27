using System;
class Aula12 {
    static void Main() {

        Console.Write("Digite a nota do aluno: ");
        int nota = int.Parse(Console.ReadLine());
        string resultado = "Reprovado";  

        if(nota >= 6) {
            if(nota>9){resultado = "Aprovado com louvor";
            }else{resultado = "Aprovado";
            }
            
        }
        else if (nota < 6 && nota >= 4) {
            if(nota>5){resultado = "recuperação com altas chances";
            }else{resultado = "recuperação com baixas chances";
            }
        }
        else {
            if(nota>3){resultado = "Reprovado por pouco";
            }else{resultado = "reprovado por muito";
            }
        }
        Console.WriteLine("Resultado: {0}", resultado);
           

    }
}