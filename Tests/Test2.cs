using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetranTest.Tests
{
    internal class Test2 : BaseTest, ITest
    {
        public override string ID { get; }
        private TestResult test1result;
        private string error = string.Empty;
        private string dirTest1;
        public Test2(string id, string dirTest1) : base(id, new CancellationTokenSource())

        {
            ID = id;
            this.dirTest1 = dirTest1;
            
        }
        public async Task Run()
        {
            GetResultTest1FromFile();

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
                switch (test1result) 
                {
                    case TestResult.None: error = "Не было тестирования"; break;
                    case TestResult.Ok: error = "Нет ошибки"; break;
                    case TestResult.Error: error = GenerateErrorName(); break;
                }
            }

            WriteResultFile();
        }
        public void Cancel()
        {
            cancelToken.Cancel();
        }

        private string GenerateErrorName()
        {
            return $"Ошибка #{new Random().Next(1,999)}";
        }
        public string GetTextResult()
        {
            return error;
        }

        protected override void WriteResultFile()
        {
            string dir = nameof(Test2);
            string file = $"{ID}.txt";
            string path = Path.Combine(dir, file);

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            File.WriteAllText(path, GetTextResult());
        }
        
        private void GetResultTest1FromFile()
        {
            string file = $"{ID}.txt";
            string path = Path.Combine(dirTest1, file);

            string resTest1 = File.ReadAllText(path);

            switch (resTest1)
            {
                default:
                case "Тест не проведен": test1result = TestResult.None;break;
                case "Ошибка": test1result = TestResult.Error; break;
                case "Успех": test1result = TestResult.Ok; break;
                    
            }
             
        }
    }
}
