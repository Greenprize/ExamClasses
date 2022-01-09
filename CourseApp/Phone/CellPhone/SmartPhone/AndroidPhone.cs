﻿namespace CourseApp
{
    using System;

    public class AndroidPhone : SmartPhone, IProduct
    {
        private AppStore appSt = new AppStore("AppStore");

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
            appSt.Apps("Subway", 0, "Android");
            appSt.Present();
        }
    }
}
