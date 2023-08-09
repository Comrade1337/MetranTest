using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetranTest.Tests
{
    internal class Test3 : BaseTest, ITest
    {
        public override string ID { get; }

        int? myRndInt = null;
        double? myRndDbl = null;
        string myRndStr = null;

        public Test3(string id)
            : base(id, new CancellationTokenSource())
        {
            ID = id;
        }

        async public Task Run()
        {
            try
            {
                await Task.Delay(100, cancelToken.Token);
            }
            catch (Exception ex)
            {
                //TODO обработали :)
            }

            //если тест не был отменен       
            if (!cancelToken.IsCancellationRequested)
            {
                myRndInt = new Random().Next();
                myRndDbl = new Random().NextDouble();
                myRndStr = Guid.NewGuid().ToString();
            }

            WriteResultFile();
        }
        public void Cancel()
        {
            cancelToken.Cancel();
        }

        public string GetTextResult()
        {
            return
               ((myRndInt != null) ? myRndInt.ToString() : "none") + Environment.NewLine +
               ((myRndDbl != null) ? myRndDbl.ToString() : "none") + Environment.NewLine +
               ((myRndStr != null) ? myRndStr.ToString() : "none") + Environment.NewLine;
        }

        protected override void WriteResultFile()
        {
            string dir = nameof(Test3);
            string file = $"{ID}.txt";
            string path = Path.Combine(dir, file);

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            File.WriteAllText(path, GetTextResult());
        }
    }
}
