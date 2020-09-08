using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PII_Game_Of_Life
{
    /*
        Esta clase es experta en leer archivos y crear un board ya que tiene la informacion necesaria para poder hacerlo.
        Cumple con SRP ya que la razon de cambio seria cambiar la forma en la que se crea un board del juego.
    */
    public class Lector 
    {
        public static bool[,] LectorBoard(string url)
        {
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y = 0 ; y < contentLines.Length; y++)
            {
                for (int x = 0 ; x < contentLines[y].Length ; x++)
                {
                    if(contentLines[y][x] == '1')
                    {
                        board[x,y] = true;
                    }
                }
            }
            return board;
        }
    }
}