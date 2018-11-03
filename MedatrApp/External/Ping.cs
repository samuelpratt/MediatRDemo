using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedatrApp.External
{
    public class Ping : IPing
    {
        string IPing.Ping(string host)
        {
            return host + " is Ponging";
        }
    }
}
