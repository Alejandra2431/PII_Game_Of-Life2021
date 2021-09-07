using System;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero(@"../../assets/board.txt");
            Juego juego = new Juego(tablero);
            ImpresorTablero.MostrarTablero(juego);
        }
    }
}
