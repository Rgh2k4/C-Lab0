
using System.Numerics;
using System.Security.Cryptography;

class Program
{

    static int num = 20;
    static void Main(string[] args)
    {
        int x = 10;
        double d = 45.23;

        float f = 22.3f;
        num = 200;
        bool b = true;

        char c = 'c';
        string r = "Robert";

        Console.WriteLine("Please enter a low number: ");
        int lowNum = GetLowNumber();
        int highNum = GetHighNumber(lowNum);
        int difference = highNum - lowNum;

        int sum = highNum + lowNum;

        Console.WriteLine($"The difference between the numbers is {difference} and the sum total of the numbers is {sum}");

       

        int[] arr = { 20, 30, 40 };
        int[] arr1 = new int[10];

        arr1[3] = 30;

        List<double> ListOfNumbers = new List<double>();
        for (int i = 0; i <10; i++)
        {
            ListOfNumbers.Add(i*10);
            Console.WriteLine($"The value at index {i} is: {ListOfNumbers[i]}");
        }


        using (StreamWriter sw = new StreamWriter("\"C:\\Users\\rgh2k\\source\\repos\\ConsoleApp1\\ConsoleApp1\\Numbers.txt\""))
        {
            foreach(double number in ListOfNumbers)
            {
                sw.WriteLine(number);
            }

        }

    }

    public static int GetLowNumber()
    {
        int newLow;
        while (true)
        {
            string lowNum = Console.ReadLine();
            //Converting string into integer
            bool t = int.TryParse(lowNum, out newLow);
            if (t && newLow > 0)
            {
                return newLow;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a low positive number");
            }
        }
    }

    public static int GetHighNumber(int  lowNum)
    {
        int newHigh = 0;
        Console.WriteLine("Please enter a high number");
        while (true)
        {
            string userInput = Console.ReadLine();
            bool t = int.TryParse(userInput, out newHigh);
            if (t && newHigh > lowNum)
            {
                return newHigh;
            }
            else
            {
                Console.WriteLine("Invalid input, high number must be greater than the low number, please try again");
            }
        }
    }
}