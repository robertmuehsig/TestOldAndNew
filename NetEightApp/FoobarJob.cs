using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEightApp
{
    internal class FoobarJob
    {
        public void Run([NotNullWhen(returnValue: false)] out string? errorMessage)
        {
            errorMessage = null;
            Console.WriteLine("Running FoobarJob");
        }
    }
}
