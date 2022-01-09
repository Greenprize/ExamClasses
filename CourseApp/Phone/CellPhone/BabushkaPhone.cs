namespace CourseApp
{
    using System;

    public class BabushkaPhone : CellPhone, IProduct, IRadioModule
    {
        private double price;

        public BabushkaPhone(string name, double price, string typeOfRadioModule)
        {
            Name = name;
            Price = price;
            TypeOfRadioModule = typeOfRadioModule;
        }

        public string Name { get; set; }

        public string TypeOfRadioModule { get; }

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
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Radio Module: {(string.IsNullOrEmpty(TypeOfRadioModule) ? "none" : TypeOfRadioModule)} Price: {Price}$");
        }
    }
}
