using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;


namespace Slcf_MAPA.Dynamics.Model
{
    public class DynamicsPressaoArterialModel : DynamicsModelBase
    {
        public string Name { get; set; }
        public int Sistolica { get; set; }
        public int BPM { get; set; }
        public int Distolica { get; set; }
        public DateTime CreateDate { get; set; }

        public EntityReference CategorizarpaId = null;

        List<DynamicsPressaoArterialModel> ListPressaoArterial = new List<DynamicsPressaoArterialModel>();
    }
}
