using System;
using playerX;
					
class Program
{
	static void Main (string[] args) {
        string name;
        char[] arr = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
        int mjesto;
        bool gotovo = false;


        Console.WriteLine("Enter player X name: ");
        name = Console.ReadLine();

        player player1 = new player(Name);

        Console.WriteLine("Enter player O name: ");
        name = Console.ReadLine();

        player player2 = new player(Name);

        // mreza i check
        writeBoard(arr);
        over = check(arr);
        if(over){
            Console.WriteLine("Pobjedio je igrac " + player1.GetName());
            break;
        }
    }

    private static void writeBoard(char[] arr) {
        // mreza
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2} ", arr[0], arr[1], Array[2]);
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2} ", arr[3], arr[4], Array[5]);
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" {0} | {1} | {2} ", arr[6], arr[7], Array[8]);
        Console.WriteLine("___|___|___");

        Console.WriteLine("Igrac" + player1.GetName() + "je na redu: ");
        mjesto = int.Parse(Console.ReadLine());
        arr[mjesto - 1] = 'X';

        
    }

    private static bool check(char[] arr) {
        if(arr[0] == arr[1] == arr[2]){
            return true;
        } else {
            return false;
        }

        if(arr[3] == arr[4] == arr[5]){
            return true;
        } else {
            return false;
        }

        if(arr[6] == arr[7] == arr[8]){
            return true;
        } else {
            return false;
        }
    }
}