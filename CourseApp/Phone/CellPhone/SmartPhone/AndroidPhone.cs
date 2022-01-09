namespace CourseApp
{
    using System;

    public class AndroidPhone : SmartPhone, IProduct
    {
        private double price;

        public AndroidPhone(string name, float diagonal, double price, string typeOfScreen)
        {
            Name = name;
            Price = price;
            Diagonal = diagonal;
            Matrix matrix = new Matrix(typeOfScreen);
            Matriks = matrix.InstallMatrix(diagonal);
        }

        public string Name { get; set; }

        public string Matriks { get; }

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
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Diagonal: {Diagonal} Matrix: {(string.IsNullOrEmpty(Matriks) ? "none" : Matriks)} Price: {Price}$");
        }
    }
}
