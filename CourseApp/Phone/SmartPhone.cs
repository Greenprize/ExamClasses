namespace CourseApp
{
    public abstract class SmartPhone : CellPhone, IPaymentSystem
    {
        private float diagonal = 0;
        private double wallet;

        public float Diagonal
        {
            get
            {
                return diagonal;
            }

            set
            {
                if (value > 0)
                {
                    diagonal = value;
                }
            }
        }

        public double Wallet { get; set; }

        public double Pay(double payment)
        {
            return this.Wallet = Wallet - payment;
        }
    }
}
