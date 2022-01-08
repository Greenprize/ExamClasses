namespace CourseApp
{
    using System;

    public class Case : IProduct
    {
        private double price;

        public Case(string name, double price, string material)
        {
            Name = name;
            Price = price;
            Material = material;
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

        public string Material { get; set; }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Material: {(string.IsNullOrEmpty(Material) ? "none" : Material)} Price: {Price}$");
        }
    }
}
