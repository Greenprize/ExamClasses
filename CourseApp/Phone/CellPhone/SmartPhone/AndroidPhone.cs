namespace CourseApp
{
    using System;

    public class AndroidPhone : SmartPhone, IProduct, ICamera
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

        public void MakePhoto()
        {
            Console.WriteLine("I'm taking a photo, please smile!");
        }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Diagonal: {Diagonal} Price: {Price}$");
        }
    }
}
