namespace FizzBuzzWhiteboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(6));
            Console.WriteLine(FizzBuzz(8));
            Console.WriteLine(FizzBuzz(10));
            Console.WriteLine(FizzBuzz(13));
            Console.WriteLine(FizzBuzz(15));
            Console.WriteLine(FizzBuzz(19));
            Console.WriteLine(FizzBuzz(20));
            Console.WriteLine(FizzBuzz(22));
            Console.WriteLine(FizzBuzz(24));
            Console.WriteLine(FizzBuzz(28));
            Console.WriteLine(FizzBuzz(30));
        }

        public static string FizzBuzz(int num)
        {
            string result = "";

            if (num % 3 == 0)
                result = "fizz";

            if (num % 5 == 0)
                result += "buzz";

            return result;
        }
    }
}