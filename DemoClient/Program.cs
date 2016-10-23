using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClient client = new DemoClient();

            Console.WriteLine("Demo Service Bus Client");
            Console.WriteLine(client.GetData(200));
            Console.ReadKey();
        }
    }
}
