namespace without_ioc.domain
{
    public class Calculator
    {
        public int Sum(string sx, string sy, string sz) {
            var x = int.Parse(sx);
            var y = int.Parse(sy);
            var z = int.Parse(sz);

            var sum = x + y + z;

            return sum;
        }
    }
}