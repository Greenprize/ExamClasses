namespace CourseApp
{
    using System;

    public class AndroidPhone : SmartPhone, IProduct, IVoiceAssist
    {
        private double price;

        private bool isFirstCallAnAssistant = true;

        public AndroidPhone(string name, float diagonal, double price)
        {
            Name = name;
            Price = price;
            Diagonal = diagonal;
            NameAssistant = "Ivan";
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

        public string NameAssistant { get; }

        public string CallAnAssistant()
        {
            if (isFirstCallAnAssistant)
            {
                isFirstCallAnAssistant = false;
                return $"Hello, I'm {NameAssistant} your voice assistant. How can I help you?";
            }

            return $"Hello, how can I help you?";
        }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Diagonal: {Diagonal} Price: {Price}$");
        }

        public string RecallAnAssistant()
        {
            return "Goodbye!";
        }
    }
}
