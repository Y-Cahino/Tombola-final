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
            int c1v=0,c2v=0;
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
            nc1();
            nc2();
            gct1();
            gct2();
            //estrazione
            for (int i = 0; i < 90; i++)
            {
                y = estrai();
                x = cdx();
                z = cdz();
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x, z);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(y);
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(x, z);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(y);
                    Thread.Sleep(1000);
                }
                ifct1();
                ifct2;
                Thread.Sleep(2000);
            }
            int estrai();
            {
                int a;
                do
                {
                    a = r.Next(1, 91);
                } while (v[a - 1] == true);
                v[a - 1] = true;
                return a;

            }
            int cdx
            int cdz
            


        }
    }
}
