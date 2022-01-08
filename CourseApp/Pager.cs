namespace CourseApp
{
    using System;

    public class Pager : IProduct
    {
        private double price;

        public Pager(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }

        public string ReadText(string message)
        {
            return message;
        }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Price: {Price}$");
        }
    }
}
