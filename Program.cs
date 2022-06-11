using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacProject
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1, c2, c3, c4, c5, c6, c7, c8, c9, c = 'x';
            c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = ' ';
            int i = 0;
            Console.WriteLine("Welcome to the tictactoe game");

            do
            {

                Console.WriteLine("\n" + c1 + "|" + c2 + "|" + c3 + "\n ----\n"
                                       + c4 + "|" + c5 + "|" + c6 + "\n ----\n"
                                       + c7 + "|" + c8 + "|" + c9 + "\n");

                if (++i > 9)
                    break;

                bool ok = false;
                do
                {
                    Console.WriteLine("first user ");
                    switch (Console.ReadLine())
                    {
                        case "1": if (c1 == ' ') { c1 = c; ok = true; }; break;
                        case "2": if (c2 == ' ') { c2 = c; ok = true; }; break;
                        case "3": if (c3 == ' ') { c3 = c; ok = true; }; break;
                        case "4": if (c4 == ' ') { c4 = c; ok = true; }; break;
                        case "5": if (c5 == ' ') { c5 = c; ok = true; }; break;
                        case "6": if (c6 == ' ') { c6 = c; ok = true; }; break;
                        case "7": if (c7 == ' ') { c7 = c; ok = true; }; break;
                        case "8": if (c8 == ' ') { c8 = c; ok = true; }; break;
                        case "9": if (c9 == ' ') { c9 = c; ok = true; }; break;

                    }
                    if (!ok) { Console.WriteLine("What are you trnna do??"); }
                } while (!ok);
                if (c == 'x')
                    c = 'o';
                else
                    c = 'x';
            } while (true);
            Console.WriteLine("Game over");
            Console.ReadLine();
        }
    }
}
