using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedatrApp.External
{
    public interface IPing
    {
        string Ping(string host);
    }
}
