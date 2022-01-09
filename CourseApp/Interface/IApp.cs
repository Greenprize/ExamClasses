namespace CourseApp
{
    public interface IApp : IProduct
    {
        string OS { get; set; }

        string InstallApp();

        string DeleteApp();

        string RunApp();
    }
}
