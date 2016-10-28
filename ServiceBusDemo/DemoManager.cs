using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBusDemo
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
       ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class DemoManager : IDemoService
    {
        public string GetData(int data)
        {
            Console.WriteLine($"The data service was called with this paramater: {data}");
            return $"The data passed in was {data}";
        }
    }
}
