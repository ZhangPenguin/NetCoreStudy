using NetCoreStudy;

namespace ServiceBLL
{
    public class Test : ITest
    {
        void ITest.Test()
        {
            Console.WriteLine("Test");
        }
    }
}