namespace CourseApp
{
    using System;

    public class App : IApp
    {
        private double price;

        public App(string name, double price, string os)
        {
            Name = name;
            Price = price;
            OS = os;
        }

        public string OS { get; set; }

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

        public void Present()
        {
            Console.WriteLine($@"Apps:   Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} OS: {(string.IsNullOrEmpty(OS) ? "none" : OS)} Price: {Price}$");
        }
    }
}
