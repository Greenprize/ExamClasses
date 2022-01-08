namespace CourseApp
{
    public interface IPaymentSystem
    {
        double Wallet { get; set; }

        double Pay(double payment);
    }
}
