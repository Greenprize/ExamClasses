namespace CourseApp
{
    using System;

    public class LandLinePhone : Phone, IProduct
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public void Present()
        {
            Console.WriteLine($"Name: {Name} Price: {Price}$");
        }
    }
}
