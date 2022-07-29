using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;

namespace Slcf_MAPA.WebApi.Models
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
        public Connect365()
        {
        }
        private void CreateConnection()
        {

            CrmServiceClient crmServiceClient = new CrmServiceClient(_ConnectionString);
            if (crmServiceClient.IsReady)
            {
                _service = crmServiceClient;
            }
            else
            {
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
