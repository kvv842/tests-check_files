using CheckFilesConsoleApp1.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckFilesConsoleApp1.Files
{
    public class CssFile : FileBase
    {
        public override string[] Extensions => new[] { ".CSS" };

        public override IOperation Operation { get; } = new CountDivOperation();
    }
}
