﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Logger
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level) : base(level)
        {
        }

        public override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
