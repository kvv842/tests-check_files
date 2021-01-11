using CheckFilesConsoleApp1.Operations;
using System.IO;
using System.Linq;

namespace CheckFilesConsoleApp1.Files
{
    public abstract class FileBase
    {
        public abstract IOperation Operation { get; }

        public abstract string[] Extensions { get; }

        public void Check(string fullPath)
        {
            var ext = Path.GetExtension(fullPath).ToUpper();

            if (Extensions.Any(a => a.ToUpper() == ext))
            {
                var text = System.IO.File.ReadAllText(fullPath); 

                var result = Operation.Do(text);

                using (var stream = System.IO.File.Create($"{fullPath}-{Operation.Name}-{result}"))
                {
                    stream.Close();
                }
            }
        }
    }
}
