namespace juegoCartas;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("numero de caras a jugar:");
        int caras= int.Parse(Console.ReadLine());

        Dado jugador1= new Dado(caras);
        Dado jugador2= new Dado(caras);

        Console.WriteLine(" oprima cualquier tecla para continuar");
        Console.ReadKey();

        juego jogo= new juego(jugador1,jugador2);
        jogo.MostrarGanador();

    }
}

