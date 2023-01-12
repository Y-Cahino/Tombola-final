using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Corsi_and_Orsi36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare
            int x,y,z=2;
            Random r=new Random();
            bool[] v = new bool[90];
            int[,] c1 = new int[9, 3];
            int[,] c2 = new int[9, 3];
            //tabella
            Console.WriteLine("Generazione tabella");
            for(int i=0; i<9;i++)
            {
                x = 13;
                for(int j=0; j<10;j++)
                {
                    Console.SetCursorPosition(x,z);
                    Console.WriteLine("*");
                    x += 2;
                }
                z++;
            }
            //estrazione
            for(int i=0; i<90;i++)
            {
                
            }
            
                

        }
    }
}
