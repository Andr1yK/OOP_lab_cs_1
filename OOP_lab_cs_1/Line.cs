namespace OOP_lab_cs_1
{
    /*
     * Implement the Line class.
     * The linear equation y = Ax + B.
     * Field first - real number, coefficient A;
     * field second - real number, coefficient B (A is not zero).
     * Implement the root( ) method - calculating the root of a linear equation.
     * The method should check if the coefficient A is not equal to zero.
     */
    
    public class Line
    {
        private double _first;
        private double _second;

        // setter and getter for First field with validation
        public double First
        {
            get => _first;
            set
            {
                if (value == 0)
                {
                    throw new System.Exception("A is equal to zero.");
                }
                
                _first = value;
            }
        }

        public double Second
        {
            get => _second;
            set => _second = value;
        }

        private Line(double first, double second)
        {
            _first = first;
            _second = second;
        }

        public double Root()
        {
            if (_first == 0)
            {
                throw new System.Exception("A is equal to zero.");
            }
            
            return -_second / _first;
        }
        
        // init method with arguments and check if A is not equal to zero.
        public static Line Init(double first, double second)
        {
            if (first == 0)
            {
                throw new System.Exception("A is equal to zero.");
            }

            return new Line(first, second);
        }

        public void Display()
        {
            System.Console.WriteLine($"y = {_first} | x = {_second}");
        }

        public void Read()
        {
            System.Console.Write("Enter A: ");
            _first = double.Parse(System.Console.ReadLine());
            
            System.Console.Write("Enter B: ");
            _second = double.Parse(System.Console.ReadLine());
        }
    }
}