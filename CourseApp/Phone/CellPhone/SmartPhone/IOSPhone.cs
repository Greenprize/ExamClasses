namespace CourseApp
{
    using System;

    public class IOSPhone : SmartPhone, IProduct, IRadioModule
    {
        private double price;

        public IOSPhone(string name, float diagonal, double price, string typeOfRadioModule)
        {
            Name = name;
            Price = price;
            Diagonal = diagonal;
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
                    this.price = value;
                }
            }
        }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Diagonal: {Diagonal} Radio Module: {(string.IsNullOrEmpty(TypeOfRadioModule) ? "none" : TypeOfRadioModule)} Price: {Price}$");
        }
    }
}
