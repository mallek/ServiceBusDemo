using System;
using System.Security.Principal;
using System.ServiceModel;

namespace ServiceBusDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!IsAdministrator())
            {
                Console.WriteLine("You must run this applicaiton in administrator mode");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Starting up service...");
            Console.WriteLine("");

            ServiceHost host = new ServiceHost(typeof(DemoManager));

            host.Open();
            Console.WriteLine("Service {0} started.", nameof(DemoManager));

            foreach (var endpoint in host.Description.Endpoints)
            {
                Console.WriteLine("Listening on endpoint:");
                Console.WriteLine($"Address: {endpoint.Address.Uri}");
                Console.WriteLine($"Binding: {endpoint.Binding.Name}");
                Console.WriteLine($"Contract: {endpoint.Contract.ConfigurationName}");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
