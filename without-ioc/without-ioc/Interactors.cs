using without_ioc.domain;
using without_ioc.provider;
using without_ioc.viewmodel;

namespace without_ioc
{
    public class Interactors
    {
        private readonly Calculator _calculator = new Calculator();
        private readonly Protokoll _protokoll = new Protokoll();
        private readonly ValueProvider _valueProvider = new ValueProvider();

        public SumVM Add(AddVM addVm) {
            var z = _valueProvider.ReadZ();
            var sum = _calculator.Sum(addVm.X, addVm.Y, z.ToString());
            _protokoll.Log(addVm.X, addVm.Y, z, sum);
            return new SumVM { X = addVm.X, Y = addVm.Y, Sum = sum.ToString()};
        }
    }
}