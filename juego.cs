using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace juegoCartas
{
    public class juego
    {
        Random rng= new Random();
        Dado dadoJugador1;
        Dado dadoJugador2;

        public juego(Dado dp1,Dado dp2){
            dadoJugador1= dp1;
            dadoJugador2= dp2;
        }
        public int LanzarDado(Dado dplay){
               int resul= rng.Next(1,dplay.caras);
            return resul;
        }
        public void MostrarGanador(){
            int caraJugador1,caraJugador2;

            do
            {
            caraJugador1= LanzarDado(dadoJugador1);
            Console.WriteLine("dado jugador uno: {0}", caraJugador1);
            caraJugador2= LanzarDado(dadoJugador2);
            Console.WriteLine("dado jugador uno: {0}", caraJugador2);
            } while (caraJugador1==caraJugador2);

            if (caraJugador1 < caraJugador2)
            {
                Console.WriteLine("gana jugador dos con: {0} ",caraJugador2);
            }
            if (caraJugador1 > caraJugador2)
            {
                Console.WriteLine("gana jugador dos con: {0} ",caraJugador1);
            }
        }

    }
}