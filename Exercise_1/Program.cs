using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class Program
{
    // Main Method
    static public void Main(String[] args)
    {
 
        int selection;
        int a = 0;
        int b = 0;
        float answer;

		try
		{
			Console.WriteLine("Give the first number: ");
			a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give the second number: ");
            b = Int32.Parse(Console.ReadLine());
        }
		catch (Exception)
		{
            Console.WriteLine("ERROR :Input string was not in a correct format. Press any key to continue . . .");
            Environment.Exit(0);
		}

        Program p = new Program();
        selection = p.Menu();

        if (selection >= 1 && selection < 5 ) 
        {
            answer = p.Calculate(selection, a, b);
            Console.WriteLine(answer);
        }

        else
        {
            Console.WriteLine("Wrong Choice!");
        }

    }

    // Menu Method
    public int Menu()
    {
        int selectionOfMenu = 0;
        Console.WriteLine("Make Your Choice");
        Console.WriteLine("Sum(1)");
        Console.WriteLine("Subtraction(2)");
        Console.WriteLine("Multiplication(3)");
        Console.WriteLine("Division(4)");
        selectionOfMenu = Int32.Parse(Console.ReadLine());
        return selectionOfMenu;
    }

    // Calculate Method
    public float Calculate(int choice, int x, int y) 
    {
        float result = 0;

        if (choice == 1) 
        { 
            result = x + y;
        }

        else if (choice == 2) 
        { 
            result = x - y;
        }

        else if (choice == 3) 
        { 
            result = x * y;
        }

        else if (choice == 4) 
        { 
            if (y == 0)
            {
                Console.WriteLine("You cannot divide by 0");
                Environment.Exit(0);
            }
            else
            { 
                result = (float)x / (float)y;
            }
        }

        return result;

    }
}



