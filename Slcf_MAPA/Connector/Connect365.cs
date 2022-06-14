using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;

namespace Slcf_MAPA.Connector
{
    public class Connect365
    {
        protected IOrganizationService _service;
        protected string _connectionString;
        public Connect365(string connectionstring)
        {
            _connectionString = connectionstring;
            CreateConnection();
        }
        private void CreateConnection()
        {
            CrmServiceClient crmServiceClient = new CrmServiceClient(_connectionString);
            if (crmServiceClient.IsReady)
            {
                Logger.Logger.WriteToFile("Dynamics 365 successfully connected!");
                _service = crmServiceClient;
            }
            else
            {
                Logger.Logger.WriteToFile("Dynamics 365 connection fail!");
                _service = null;
            }
        }
        public IOrganizationService GetConnection() => _service;
    }
}
