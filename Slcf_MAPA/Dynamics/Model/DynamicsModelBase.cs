using Microsoft.Xrm.Sdk;
using System;

namespace Slcf_MAPA.Dynamics.Model
{
    public class DynamicsModelBase
    {
        public Guid Id { get; set; }
        public string LogicalName { get; set; }

        public Entity ToEntity() => new Entity();
    }
}
