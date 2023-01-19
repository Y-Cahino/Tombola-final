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
                ifct2();
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
            int cdx()
            {
                if(y/10==0)
                {
                    x = 11 + (y % 10 * 3);
                }
                else
                {
                    if (y % 10 != 0)
                    {
                        x = 11 + (y % 10 * 3 - 1);
                    }
                    else
                    {
                        x = 11 + y / (y / 10) * 3 - 1;
                    }
                }
                return x;
            }
            int cdz()
            {
                if(z%10==0)
                {
                    y = 2;
                }
                else
                {
                    if(z%10!= 0)
                    {
                        z = 2 + y / 10;
                    }
                    else
                    {
                        y = 1 + y / 10;
                    }
                }
                return y;
            }
            int nc1()
            {
                //vincente-trova-estrae-controlla
                //creiamo un array che permetta di controllare i numeri
                //?
                bool[] vinto = new bool[90];
                int b;
                for (int j = 0; j < 3; j++)
                {
                    bool[] c = new bool[10];
                    for (int i = 0; i < 5; i++)
                    {
                        do
                        {
                            b = r.Next(1, 91);
                            if(b==90)
                            {
                                i--;
                            }
                        } while (vinto[b - 1] == true || c[b / 10] == true);
                        vinto[b - 1] = true;
                        c[b / 10] = true;
                        if(b == 90) //spostare nell'altra colonna, 9-1=8
                        {
                            c1[8,j]=90;
                        }
                        else
                        {
                            c1[b / 10, j] = b; //se non è equivalente a 90
                        }
                    }
                    for(int i = 0; i < 9; i++) //creazione indice
                    {
                        c[i] = false;
                    }
                }
                return 0;
            }
            int nc2()
            {
                //stesso procedimento
            }
            //stampa cartella
            void gct1()
            {
                x = 0;
                z = 12;
                Console.SetCursorPosition(x, z);
                Console.WriteLine("Prima cartella:");
                for (int i = 0; i < 5; i++)
                {
                    z++;
                    if (i% 2 == 1)
                        {
                        Console.SetCursorPosition(x,z);
                        }
                }
            }
        }
    }
}
