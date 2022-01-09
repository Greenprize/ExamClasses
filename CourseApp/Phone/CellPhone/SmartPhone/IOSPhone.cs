namespace CourseApp
{
    using System;

    public class IOSPhone : SmartPhone, IProduct, IVoiceAssist
    {
        private double price;

        private bool isFirstCallAnAssistant = true;

        public IOSPhone(string name, float diagonal, double price)
        {
            Name = name;
            Price = price;
            Diagonal = diagonal;
            NameAssistant = "Siri";
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
                    this.price = value;
                }
            }
        }

        public string NameAssistant { get; }

        public string CallAnAssistant()
        {
            if (isFirstCallAnAssistant)
            {
                isFirstCallAnAssistant = false;
                return $"I'm {NameAssistant} your voice assistant. How can I help you?";
            }

            return $"Hello, do you need help?";
        }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Diagonal: {Diagonal} Price: {Price}$");
        }

        public string RecallAnAssistant()
        {
            return "Bye!";
        }
    }
}
