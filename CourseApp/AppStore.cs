namespace CourseApp
{
    using System.Collections.Generic;

    public class AppStore
    {
        private List<IApp> apps = new List<IApp>();

        public AppStore(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Apps(string name, double price, string os)
        {
            apps.Add(new App(name, price, os));
        }

        public void Present()
        {
            foreach (IApp item in apps)
            {
                item.Present();
            }
        }
    }
}
