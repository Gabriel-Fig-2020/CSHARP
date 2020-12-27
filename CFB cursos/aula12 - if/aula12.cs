using System;
class Aula12 {
    static void Main() {

        Console.Write("Digite a nota do aluno: ");
        int nota = int.Parse(Console.ReadLine());
        string resultado = "Reprovado";  

        if(nota >= 6) {
            resultado = "Aprovado";
        }
       
        Console.WriteLine("Resultado: {0}", resultado);
           

    }
}