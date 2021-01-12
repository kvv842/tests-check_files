namespace CheckFilesConsoleApp1.Operations
{
    public class BracesOperation : IOperation
    {
        public string Name => "Braces";

        public string Do(string data)
        {
            var count = 0;

            foreach (var c in data)
            {
                switch (c)
                {
                    case '{':
                        {
                            count++;
                            break;
                        }
                    case '}':
                        {
                            count--;
                            break;
                        }
                }
            }

            return (count == 0).ToString();
        }
    }
}
