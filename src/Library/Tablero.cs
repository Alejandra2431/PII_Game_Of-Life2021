using System;
using System.IO;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// La clase tablero se encarga de crear el tablero mediante un archivo .txt.
    /// Cumple con el principio SRP ya que su única responsabilidad es crear el tablero.
    /// </summary>
    public class Tablero
    {
        public string Url { get; set; }
        private string Content {get; set;}
        private string[] ContentLines {get; set;}
        public bool[,] Board {get; set;}

        public Tablero(string url)
        {
            this.Url = url;
            this.Content = File.ReadAllText(url);
            this.ContentLines = this.Content.Split('\n');
            this.Board = new bool[this.ContentLines.Length, this.ContentLines[0].Length];
            for (int  y=0; y<this.ContentLines.Length;y++)
            {
                for (int x=0; x<this.ContentLines[y].Length; x++)
                {
                    if(this.ContentLines[y][x]=='1')
                    {
                        this.Board[x,y]=true;
                    }
                }
            }
        }
    }
}
