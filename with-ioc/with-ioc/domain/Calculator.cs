using with_ioc.provider;

namespace with_ioc.domain
{
    public class Calculator
    {
        private readonly Protokoll _protokoll;
        private readonly ValueProvider _valueProvider;

        public Calculator(Protokoll protokoll, ValueProvider valueProvider) {
            _protokoll = protokoll;
            _valueProvider = valueProvider;
        }

        public int Sum(string sx, string sy) {
            var x = int.Parse(sx);
            var y = int.Parse(sy);
            var z = _valueProvider.ReadZ();

            var sum = x + y + z;
            
            _protokoll.Log(sx, sy, z, sum);

            return sum;
        }
    }
}