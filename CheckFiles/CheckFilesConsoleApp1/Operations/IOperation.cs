namespace CheckFilesConsoleApp1.Operations
{
    public interface IOperation
    {
        string Name { get; }

        string Do(string data);
    }
}
