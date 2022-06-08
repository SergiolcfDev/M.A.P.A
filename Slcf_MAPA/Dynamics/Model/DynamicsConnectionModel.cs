using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slcf_MAPA.Dynamics.Model
{
    internal class DynamicsConnectionModel
    {
        private string AuthType { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        private string Url { get; set; }
        private string AppId { get; set; }
        private string RedirectURI { get; set; }
        private string LoginPrompt { get; set; }
        private string ConnectionString { get; set; }

        IOrganizationService service = null;
    }
}
