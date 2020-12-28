using System;

static public  class Jogador {
        static public int energia;
        static public bool vivo;
        static public string nome;

        static public void iniciar(string n) {
            energia = 100;
            vivo = true;
            nome = n;
        }
        static public void Info() {
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}", energia);
            Console.WriteLine("Estado jogador: {0}\n", vivo);

        }

}

class Inimigo {
    static public bool alerta;//1 pos na memoria p/ todos
    public string nome;//cada um tem o seu

    

    public Inimigo(string n) {
        alerta = false;
        nome = n;
    }

    public void info() {
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("----------------");
    }

}

class Aula31 {
    static void Main() {

        Jogador.iniciar("Gaabriel");
        Jogador.Info();

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info();

    }
}