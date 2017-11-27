using System.IO;

namespace with_ioc.provider
{
    public class ValueProvider
    {
        public virtual int ReadZ() {
            var line = File.ReadAllText("z.txt");
            return int.Parse(line);
        }
    }
}