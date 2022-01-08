﻿namespace CourseApp
{
    using System;

    public class LandLinePhone : Phone, IProduct
    {
        private double price;

        public LandLinePhone(string name, double price)
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

        public void Present()
        {
            Console.WriteLine($"Name: {Name} Price: {Price}$");
        }
    }
}
