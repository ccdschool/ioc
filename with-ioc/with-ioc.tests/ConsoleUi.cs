using System;
using System.IO;

namespace with_ioc.tests
{
    public class ConsoleUi : IDisposable
    {
        private readonly TextWriter _currentTextWriter;
        private readonly StringWriter _stringWriter = new StringWriter();

        public ConsoleUi() {
            _currentTextWriter = Console.Out;
            Console.SetOut(_stringWriter);            
        }

        public string[] Output() {
            return _stringWriter.ToString().Split(new[]{Environment.NewLine}, StringSplitOptions.None);
        }

        public void Dispose() {
            Console.SetOut(_currentTextWriter);
        }
    }
}