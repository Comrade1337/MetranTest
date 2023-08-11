using System.Threading.Tasks;

namespace MetranTest.Tests
{
    internal interface ITest
    {
        Task Run();
        void Cancel();
    }
}
