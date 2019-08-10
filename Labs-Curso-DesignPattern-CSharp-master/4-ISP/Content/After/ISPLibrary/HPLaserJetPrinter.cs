﻿using System;
using System.Collections.Generic;
using System.Text;
namespace ISPLibrary
{
    public class HPLaserJetPrinter : IScan, IPrint, IFax
    {
        public void Fax(string content)
        {
            Console.WriteLine(content);
        }

        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan(string content)
        {
            Console.WriteLine(content);
        }
    }
}
