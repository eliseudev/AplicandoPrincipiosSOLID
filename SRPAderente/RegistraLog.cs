using System;
namespace SRPAderente
{
    public class RegistraLog : ILogger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}

