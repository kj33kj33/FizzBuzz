using System;
namespace FizzBuzz;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FizBuzz(15));
    }

    public static string FizBuzz(int number)
    {
        var answer = String.Empty;

        if(number % 3 == 0)
        {
            answer = "fizz";
        }

        if(number % 5 == 0)
        {
            answer += "buzz";
        }

        return answer;
    }
}