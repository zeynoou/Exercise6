namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string a = Console.ReadLine();
            var result1 = Convert.ToInt32(a);
            var result2 = Comparision(result1);
            Console.WriteLine("Your result is:" + result2);
        }

        public static bool Comparision(int a)
        {
            if (a <= 0)
                return true;
            else
                return false;
        }
    }
}