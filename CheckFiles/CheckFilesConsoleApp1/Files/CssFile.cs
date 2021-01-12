using CheckFilesConsoleApp1.Operations;

namespace CheckFilesConsoleApp1.Files
{
    public class CssFile : FileBase
    {
        public override string[] Extensions => new[] { ".CSS" };

        public override IOperation Operation { get; } = new BracesOperation();
    }
}
