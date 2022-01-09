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

        public List<IProduct> Goods(List<IProduct> list)
        {
            list.Add(new AndroidPhone("GooglePixel", 10, 100));
            list.Add(new IOSPhone("IPhone13", 100, 1000));
            return list;
        }

        public void AddProduct(string name)
        {
            goods.Add(new Product(name, 0));
        }

        public void Present()
        {
            foreach (IProduct item in Goods(goods))
            {
                item.Present();
            }
        }
    }
}
