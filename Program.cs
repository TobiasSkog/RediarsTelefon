namespace RediarsTelefon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var constructorOne = new PhoneInfo.Phone();
            var constructorTwo = new PhoneInfo.Phone("Edugrade", "Nokia");
            var constructorThree = new PhoneInfo.Phone("Edugrade", "Nokia", "Friday");

            Console.WriteLine("--------------------------------------");
            constructorOne.Introduce();
            Console.WriteLine("--------------------------------------");
            constructorTwo.Introduce();
            Console.WriteLine("--------------------------------------");
            constructorThree.Introduce();
            Console.WriteLine("--------------------------------------");

        }
    }
}