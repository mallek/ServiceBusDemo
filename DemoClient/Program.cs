using System;

namespace DemoClient
{
    class Program
    {
        private static bool exit = false;
        static void Main(string[] args)
        {

            DemoClient client = new DemoClient();
            Console.WriteLine("Demo Service Bus Client");
            Console.WriteLine("Service Endpoint: " + client.Endpoint.Address.Uri);

            while (!exit)
            {
                Console.Write("Enter an int:");
                int input = AsInt(Console.ReadLine());
                Console.WriteLine(client.GetData(input));
                Console.Write("Press Q to quit, any other key to try again: ");
                if (Console.ReadLine()?.ToUpper() == "Q")
                {
                    exit = true;
                }
            }
            
        }

        static int AsInt(object obj, int defaultInt = default(int))
        {
            if (obj == null)
                return defaultInt;

            int result;

            if (obj is Enum)
            {
                result = (int)obj;
            }
            else if (!int.TryParse(obj.ToString(), out result))
                return defaultInt;

            return result;

        }

      
    }
}
