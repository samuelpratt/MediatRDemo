using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MedatrApp.Cqrs
{
    public class PingHandler : RequestHandler<Ping, string>
    {
        private External.IPing _ping;

        public PingHandler(External.IPing ping)
        {
            _ping = ping;
        }

        protected override string Handle(Ping request)
        {
            return _ping.Ping(request.Host);
        }
    }
}
