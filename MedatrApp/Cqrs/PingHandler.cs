using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MedatrApp.External;

namespace MedatrApp.Cqrs
{
    public class PingHandler : RequestHandler<Ping, string>
    {
        private IPing _ping;

        public PingHandler(IPing ping)
        {
            _ping = ping;
        }

        protected override string Handle(Ping request)
        {
            return _ping.Ping(request.Host);
        }
    }
}
