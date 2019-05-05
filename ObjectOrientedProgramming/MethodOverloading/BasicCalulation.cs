namespace OOP.MethodOverloading
{
    public class BasicCalulation
    {
        public int Summation(int x, int y)
        {
            return x + x;
        }

        public int Summation(int x, int y, int z)
        {
            return x + x + z;
        }

        //Expression Bodied Members
        public double Summation(double x, double y) => x + y;
        public double Summation(double x, double y, double z) => x + y + z;

    }
}
