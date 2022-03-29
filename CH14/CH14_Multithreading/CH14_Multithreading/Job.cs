﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH14_Multithreading
{
    internal class Job
    {
        public void Execute()
        {
            Console.WriteLine("Execute() method execute.");
        }

        public void PrintMessage(object message)
        {
            Console.WriteLine($"Message: {message}");
        }
    }
}
