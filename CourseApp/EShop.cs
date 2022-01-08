namespace CourseApp
{
    using System.Collections.Generic;

    public class EShop
    {
        public EShop(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public List<IProduct> Goods()
        {
            var list = new List<IProduct>();
            list.Add(new AndroidPhone("GooglePixel", 10, 100));
            list.Add(new IOSPhone("IPhone13", 100, 1000));
            return list;
        }

        public void Present()
        {
            foreach (IProduct item in Goods())
            {
                item.Present();
            }
        }
    }
}
