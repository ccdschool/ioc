using System.IO;

namespace without_ioc.provider
{
    public class ValueProvider
    {
        public virtual int ReadZ() {
            var line = File.ReadAllText("z.txt");
            return int.Parse(line);
        }
    }
}