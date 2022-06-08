using System;
using System.Collections.Generic;

namespace Slcf_MAPA.Dynamics.Model
{
    internal class DynamicsCategorizarPAModel: DynamicsModelBase
    {

        public string Name { get; set; }
        public int Sitolica_de { get; set; }
        public int Sistolica_ate { get; set; }
        public int Distolica_de { get; set; }
        public int Distolica_ate { get; set; }
        public DateTime CreateDate { get; set; }
        List<DynamicsCategorizarPAModel> ListaCategorizaPA = new List<DynamicsCategorizarPAModel>();

    }
}
