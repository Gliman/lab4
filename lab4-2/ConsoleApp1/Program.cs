using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //blalbalb;
            var assembly = Assembly.GetExecutingAssembly();
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            var version = fileVersionInfo.ProductVersion;
            Console.WriteLine(version);
            Console.ReadLine();
        }
    }
}