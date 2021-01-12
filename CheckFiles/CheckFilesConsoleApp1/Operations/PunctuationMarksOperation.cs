using System.Linq;

namespace CheckFilesConsoleApp1.Operations
{
    public class PunctuationMarksOperation : IOperation
    {
        private readonly char[] _marks = new[] { '.', ',' };

        public string Name => "PunctuationMarks";

        public string Do(string data)
        {
            var count = 0L;

            foreach (var c in data)
            {
                if (_marks.Any(a => a == c))
                    count++;
            }

            return count.ToString();
        }
    }
}
