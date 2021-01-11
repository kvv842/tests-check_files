using System.Text.RegularExpressions;

namespace CheckFilesConsoleApp1.Operations
{
    public class BracesOperation : IOperation
    {
        private const string PATTERN = "<([div]+)(?:[^>=]|='[^']*'|=\"[^\"]*\" |=[^'\"\\s]*)*\\s?\\/?>";

        private Regex _regex = new Regex(PATTERN);

        public string Name => "Braces";

        public string Do(string data)
        {
            var matches = _regex.Matches(data);
            return matches.Count.ToString();
        }
    }
}
