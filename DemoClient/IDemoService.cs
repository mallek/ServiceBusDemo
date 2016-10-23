﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient
{
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        string GetData(int data);
    }
}
