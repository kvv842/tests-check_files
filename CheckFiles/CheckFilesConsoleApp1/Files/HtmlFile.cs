using CheckFilesConsoleApp1.Operations;

namespace CheckFilesConsoleApp1.Files
{
    public class HtmlFile : FileBase
    {
        public override string[] Extensions => new[] { ".HTML" };

        public override IOperation Operation { get; } = new CountDivOperation();
    }
}
