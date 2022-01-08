namespace CourseApp
{
    using System;

    public class AndroidPhone : SmartPhone, IProduct, IApp
    {
        private double price;

        public AndroidPhone(string name, float diagonal, double price)
        {
            Name = name;
            Price = price;
            Diagonal = diagonal;
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
                    price = value;
                }
            }
        }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Diagonal: {Diagonal} Price: {Price}$");
        }

        public string InstallApp()
        {
            return "App installed";
        }

        public string DeleteApp()
        {
            return "App deleted";
        }

        public string RunApp()
        {
            return "App running";
        }
    }
}
