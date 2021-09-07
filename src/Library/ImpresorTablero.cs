using System;
using System.IO;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// La clase ImpresorTablero se encarga de conocer y mostrar el estado del juego en cada momento llamando al metodo LogicaJuego de
    /// la clase Juego en un ciclo infinito.
    /// </summary>
    public class ImpresorTablero
    {
        public static void MostrarTablero(Juego juego)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<juego.BoardHeight;y++)
                {
                    for (int x = 0; x<juego.BoardWidth; x++)
                    {
                        if(juego.GameBoard[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                juego.LogicaJuego();
                Thread.Sleep(300);
            }
        }
    }
}