using System;
using System.Threading;
using System.Threading.Tasks;

namespace MetranTest.Tests
{
    internal class Test3 : BaseTest, ITest
    {
        int? myRndInt = null;
        double? myRndDbl = null;
        string myRndStr = null;

        public Test3(string id)
            : base(id, new CancellationTokenSource())
        { }

        async public Task Run()
        {
            State.Current = States.Testing3;

            
            try
            {
                await Task.Delay(ExecutionTime, cancelToken.Token);
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

            State.Current = States.WaitInput;
            WriteResultFile(nameof(Test3), $"{ID}.txt", GetTextResult());
        }
        public void Cancel() => cancelToken.Cancel();

        protected override string GetTextResult()
        {
            return
               ((myRndInt != null) ? myRndInt.ToString() : "none") + Environment.NewLine +
               ((myRndDbl != null) ? myRndDbl.ToString() : "none") + Environment.NewLine +
               ((myRndStr != null) ? myRndStr.ToString() : "none") + Environment.NewLine;
        }
    }
}
