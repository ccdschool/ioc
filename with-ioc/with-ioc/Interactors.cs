using with_ioc.domain;
using with_ioc.viewmodel;

namespace with_ioc
{
    public class Interactors
    {
        private readonly Calculator _calculator;

        public Interactors(Calculator calculator) {
            _calculator = calculator;
        }

        public SumVM Add(AddVM addVm) {
            var sum = _calculator.Sum(addVm.X, addVm.Y);
            return new SumVM { X = addVm.X, Y = addVm.Y, Sum = sum.ToString()};
        }
    }
}