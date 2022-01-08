namespace CourseApp
{
    using System;

    public class BabushkaPhone : CellPhone, IProduct, ICamera
    {
        private double price;

        public BabushkaPhone(string name, double price)
        {
            Name = name;
            Price = price;
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

        public void MakePhoto()
        {
            Console.WriteLine("I'm taking a photo, please smile!");
        }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Price: {Price}$");
        }
    }
}
