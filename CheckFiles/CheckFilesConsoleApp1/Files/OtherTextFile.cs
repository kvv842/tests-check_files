using CheckFilesConsoleApp1.Operations;

namespace CheckFilesConsoleApp1.Files
{
    public class OtherTextFile : FileBase
    {
        public override string[] Extensions => new[] { ".TXT" };

        public override IOperation Operation { get; } = new PunctuationMarksOperation();
    }
}
