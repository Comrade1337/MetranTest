using System;
using System.Threading;
using System.Threading.Tasks;

namespace MetranTest.Tests
{
    internal class Test1 : BaseTest, ITest
    {
        TestResult Result  { get; set; } = TestResult.None;

        public Test1(string id)
            : base(id, new CancellationTokenSource())
        { }   

        async public Task Run()
        {
            State.Current = States.Testing1;

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
                Result = (TestResult)new Random().Next(1, 3);
            }

            State.Current = States.WaitInput;
            WriteResultFile(nameof(Test1), $"{ID}.txt", GetTextResult());
        }

        public void Cancel() => cancelToken.Cancel();

        protected override string GetTextResult()
        {
            switch (Result)
            {
                default:
                case TestResult.None: return "Тест не проведен";

                case TestResult.Error: return "Ошибка";
                case TestResult.Ok: return "Успех";
            }
        }
    }
}
