using System;
using System.IO;
using System.Threading;

namespace MetranTest.Tests
{
    internal abstract class BaseTest
    {
        public string ID{ get; private set; }

        //Задержка 10-30 секунд
        protected const int MinTimeMSec = 10000;
        protected const int MaxTimeMSec = 30000;
        protected int ExecutionTime = new Random().Next(MinTimeMSec, MaxTimeMSec + 1);

        protected CancellationTokenSource cancelToken;
        protected abstract string GetTextResult();
        public BaseTest(string id, CancellationTokenSource cancelToken)
        {
            ID = id;
            this.cancelToken = cancelToken;
        }

        protected void WriteResultFile(string dir, string file, string content)
        {
            string path = Path.Combine(dir, file);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllText(path, content);
        }
    }
}
