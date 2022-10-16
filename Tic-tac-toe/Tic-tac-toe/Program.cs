using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int mjesto;
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool end = false;

            Console.WriteLine("Enter player 1 nickname:");
            name = Console.ReadLine();
            Player player1 = new Player(name);

            Console.WriteLine("enter player 2 nickname:");
            name = Console.ReadLine();
            Player player2 = new Player(name);

            ispisiBoard(arr);

            while (true)
            {
                Console.WriteLine("Player " + player1.getName() + "'s turn:");
                mjesto = int.Parse(Console.ReadLine());
                arr[mjesto - 1] = 'X';

                ispisiBoard(arr);
                end = provjeri(arr);
                if (end)
                {
                    Console.WriteLine(player1.getName() + "won! ");
                    break;
                }

                Console.WriteLine("Player " + player2.getName() + "'s turn:");
                mjesto = int.Parse(Console.ReadLine());
                arr[mjesto - 1] = 'O';

                ispisiBoard(arr);
                end = provjeri(arr);

                if (end)
                {
                    Console.WriteLine(player2.getName() + "won! ");
                    break;
                }
            };

        }

        private static bool provjeri(char[] arr)
        {
            // Vodoravno
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                return true;
            }
            if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                return true;
            }
            if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return true;
            }

            // Horizontalno
            if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                return true;
            }
            if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return true;
            }
            if (arr[2] == arr[7] && arr[7] == arr[8])
            {
                return true;
            }

            // X
            if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                return true;
            }
            if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                return true;
            }
            return false;
        }

        private static void ispisiBoard(char[] arr)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |      \n");
        }
    }
}