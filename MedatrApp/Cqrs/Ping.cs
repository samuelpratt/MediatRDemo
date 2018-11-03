using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MedatrApp.Cqrs
{
    public class Ping : IRequest<String> {
        public Ping(string host)
        {
            Host = host;
        }

        public String Host { private set; get; }
    }
    
}
