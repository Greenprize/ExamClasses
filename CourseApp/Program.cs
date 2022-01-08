namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var eshop = new EShop("Mobila");
            eshop.Present();
            Console.ReadLine();
        }
    }
}
