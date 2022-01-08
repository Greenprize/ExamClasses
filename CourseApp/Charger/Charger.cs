namespace CourseApp
{
    using System;

    public class Charger : IProduct
    {
        private double price;

        public Charger(string name, string typeOfJack, double price)
        {
            this.Name = name;

            this.TypeOfJack = typeOfJack;

            this.Price = price;
        }

        public string TypeOfJack { get; set; }

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

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} / Type Of Jack: {(string.IsNullOrEmpty(TypeOfJack) ? "none" : TypeOfJack)} / Price: {Price}$");
        }
    }
}
