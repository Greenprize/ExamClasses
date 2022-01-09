namespace CourseApp
{
    public abstract class SmartPhone : CellPhone
    {
        private float diagonal = 0;

        private int a = 1;

        public string GPS { get; set; } = "Eugene S.";

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

        public string GPSModule()
        {
            switch (a)
            {
                case 1:
                    GPS = "GPS";
                    a = a + 1;
                    break;

                case 2:
                    GPS = "AGPS";
                    a = a + 1;
                    break;

                case 3:
                    GPS = "Eugene S.";
                    a = 1;
                    break;
            }

            return $"You use {GPS}";
        }
    }
}
