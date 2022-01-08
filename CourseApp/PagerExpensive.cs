namespace CourseApp
{
    using System;

    public class PagerExpensive : Pager
    {
        public PagerExpensive(string name, double price)
            : base(name, price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string SendText()
        {
            _ = Console.ReadLine();
            return "Message sent";
        }
    }
}
