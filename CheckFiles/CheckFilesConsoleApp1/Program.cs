using CheckFilesConsoleApp1.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CheckFilesConsoleApp1
{
    class Program
    {
        private static List<FileBase> _observibleFiles = new List<FileBase>();

        static void Main(string[] args)
        {
            _observibleFiles.Add(new HtmlFile());
            _observibleFiles.Add(new CssFile());
            _observibleFiles.Add(new OtherTextFile());

            RunWatcher();
        }

        private static void RunWatcher()
        {
            var directory = Environment.GetCommandLineArgs()?.Skip(1)?.FirstOrDefault() ?? AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine($"{directory}");

            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = directory;

                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                watcher.Created += OnCreated;

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press 'any key' to quit the sample.");
                Console.ReadKey();
            }
        }

        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            _observibleFiles.ForEach(a => a.Check(e.FullPath));

            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        }
    }
}
