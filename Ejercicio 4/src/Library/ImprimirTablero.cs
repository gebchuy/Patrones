using System;
using System.Threading;
using System.Text;

namespace PII_Game_Of_Life
{
    /*
        Esta clase cumple con SRP ya que su unica responsabilidad es imprimir por consola el tablero, su unica razon de cambio 
        seria modificar la representacion del tablero.
        Esta clase es Experta en imprimir el tablero ya que tiene todos los datos necesarios.


    */
    public class ImprimirTablero
    {
        
        public static void Print()
        {
            bool[,] b = Lector.LectorBoard("../../assets/board.txt");//variable que representa el tablero
            
            int width = b.GetLength(0);//variabe que representa el ancho del tablero
            int height = b.GetLength(1);  //variabe que representa altura del tablero
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
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
                Juego.Game();
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                Thread.Sleep(300);
            }
        }
        
    }
}
