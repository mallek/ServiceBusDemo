using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceBusDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
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

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
