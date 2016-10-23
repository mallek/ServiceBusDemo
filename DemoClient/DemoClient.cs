using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient
{
    public class DemoClient : ClientBase<IDemoService>, IDemoService
    {
        public string GetData(int data)
        {
            return Channel.GetData(data);
        }
    }

    
}
