﻿using System.IO;

namespace dotnetCampus.Cli.Tests.Fakes
{
    public class IOOptions
    {
        [Option('f', "File")]
        public FileInfo? File { get; set; }

        [Option('d', "Directory")]
        public DirectoryInfo? Directory { get; set; }
    }
}
