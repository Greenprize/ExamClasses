namespace CourseApp
{
    using System;

    public class Product : IProduct
    {
        private double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Price: {Price}$");
        }
    }
}
