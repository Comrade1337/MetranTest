using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MetranTest.Tests
{
    internal class Test2 : BaseTest, ITest
    {
        TestResult test1result;
        string error = string.Empty;
        string dirTest1;

        public Test2(string id, string dirTest1)
            : base(id, new CancellationTokenSource())
        {
            this.dirTest1 = dirTest1;
        }

        public async Task Run()
        {
            State.Current = States.Testing2;

            GetResultTest1FromFile();
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
                switch (test1result)
                {
                    case TestResult.None: error = "Не было тестирования"; break;
                    case TestResult.Ok: error = "Нет ошибки"; break;
                    case TestResult.Error: error = GenerateErrorName(); break;
                }
            }

            State.Current = States.WaitInput;
            WriteResultFile(nameof(Test2), $"{ID}.txt", error);
        }

        public void Cancel() => cancelToken.Cancel();
        string GenerateErrorName() => $"Ошибка #{new Random().Next(1, 999)}";
        protected override string GetTextResult() => error;
        
        private void GetResultTest1FromFile()
        {
            string file = $"{ID}.txt";
            string path = Path.Combine(dirTest1, file);

            string resTest1 = string.Empty;
            try
            {
                resTest1 = File.ReadAllText(path);
            }
            catch (Exception ex) { }

            switch (resTest1)
            {
                default:
                case "Тест не проведен": test1result = TestResult.None; break;
                case "Ошибка": test1result = TestResult.Error; break;
                case "Успех": test1result = TestResult.Ok; break;
            }
        }
    }
}
