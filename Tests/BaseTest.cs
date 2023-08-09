using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetranTest.Tests
{
    internal abstract class BaseTest
    {
        public abstract string ID{ get; }
        protected CancellationTokenSource cancelToken;
        public BaseTest(string id, CancellationTokenSource cancelToken)
        {
            //ID = id;
            this.cancelToken = cancelToken;
        }

        protected abstract void WriteResultFile();

    }
}
