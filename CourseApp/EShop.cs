namespace CourseApp
{
    using System.Collections.Generic;

    public class EShop
    {
        private List<IProduct> goods = new List<IProduct>();

        private Dictionary<string, int> catolog = new Dictionary<string, int>()
        {
            { "IPhone 13", 2 },
            { "Samsung A50", 1 },
            { "Boby B", 3 },
            { "Babushka 94", 4 },
            { "IPhone 14", 2 },
        };

        public EShop(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Goods()
        {
            goods.Add(new AndroidPhone("GooglePixel", 10, 100));
            goods.Add(new IOSPhone("IPhone 13", 100, 1000));
        }

        public void AddPhone(string name, double price)
        {
            int value;
            catolog.TryGetValue(name, out value);
            switch (value)
            {
                case 3:
                    goods.Add(new LandLinePhone(name, price));
                    break;
                case 4:
                    goods.Add(new BabushkaPhone(name, price));
                    break;
            }
        }

        public void AddPhone(string name, float display, double price)
        {
            int value;
            catolog.TryGetValue(name, out value);
            switch (value)
            {
                case 1:
                    goods.Add(new AndroidPhone(name, display, price));
                    break;
                case 2:
                    goods.Add(new IOSPhone(name, display, price));
                    break;
            }
        }

        public void Present()
        {
            Goods();
            AddPhone("IPhone 13", 10, 100);
            AddPhone("Babushka 94", 100);
            foreach (IProduct item in goods)
            {
                item.Present();
            }
        }
    }
}
