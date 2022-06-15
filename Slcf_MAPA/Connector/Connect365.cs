using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;

namespace Slcf_MAPA.Connector
{
    public class Connect365
    {
        private string _ConnectionString;
        private IOrganizationService _service;
        public Connect365(string connectionstring)
        {
            SetConnectionString(connectionstring);
            CreateConnection();
        }
        private void CreateConnection()
        {

            CrmServiceClient crmServiceClient = new CrmServiceClient(_ConnectionString);
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
        private void SetConnectionString(string connectionString)
        {
            _ConnectionString = connectionString;
        }
    }
}