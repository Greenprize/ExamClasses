namespace CourseApp
{
    using System.Collections.Generic;

    public class EShop
    {
        private List<IProduct> goods = new List<IProduct>();

        public EShop(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Goods()
        {
            goods.Add(new AndroidPhone("GooglePixel", 10, 100));
            goods.Add(new IOSPhone("IPhone13", 100, 1000));
        }

        public void Present()
        {
            Goods();
            foreach (IProduct item in goods)
            {
                item.Present();
            }
        }
    }
}
