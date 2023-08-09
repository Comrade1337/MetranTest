using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetranTest.Tests
{
    internal interface ITest
    {
        //string ID { get; }
        Task Run();
        void Cancel();
        string GetTextResult();
    }
}
