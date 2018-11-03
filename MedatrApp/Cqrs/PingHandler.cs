using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MedatrApp.Cqrs
{
    public class SyncHandler : RequestHandler<Ping, string>
    {
        protected override string Handle(Ping request)
        {
            return request.Host + " is Ponging";
        }
    }
}
