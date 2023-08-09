using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MetranTest.Tests
{
    internal class Test1 : BaseTest, ITest
    {
        public override string ID { get; }
        //enum Results
        //{
        //    NoneTest, Err1, Err2, Err3, Ok1, Ok2, Ok3, COUNT
        //}
        //Results result = Results.NoneTest;

        public TestResult Result  { get; private set; } = TestResult.None;

        public Test1(string id)
            : base(id, new CancellationTokenSource())
        {
            ID = id;
        }

        async Task ITest.Run()
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
                //result = (Results)new Random().Next(1, (int)Results.COUNT);
                Result = (TestResult)new Random().Next(1, 3);
            }

            WriteResultFile();
        }

        public void Cancel() =>
            cancelToken.Cancel();

        protected override void WriteResultFile()
        {
            string dir = nameof(Test1);
            string file = $"{ID}.txt";
            string path = Path.Combine(dir, file);

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            File.WriteAllText(path, GetTextResult());
        }

        public string GetTextResult()
        {
            switch (Result)
            {
                default:
                case TestResult.None: return "Тест не проведен";

                case TestResult.Error: return "Ошибка";
                case TestResult.Ok: return "Успех";
            }
        }


        //public string GetResult()
        //{
        //
        //    switch (result)
        //    {
        //        case Results.NoneTest: return "Тест не проведен";
        //
        //        case Results.Err1: return "Ошибка тестирования #1";
        //        case Results.Err2: return "Ошибка тестирования #2";
        //        case Results.Err3: return "Ошибка тестирования #3";
        //
        //        case Results.Ok1:
        //        case Results.Ok2:
        //        case Results.Ok3: return "Успех тестирования";
        //
        //        default: return "Неизвестный результат";
        //    }
        //}
    }
}
