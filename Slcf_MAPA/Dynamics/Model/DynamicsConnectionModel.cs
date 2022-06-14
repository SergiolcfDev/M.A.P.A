using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System.Configuration;

namespace Slcf_MAPA.Dynamics.Model
{
    public class DynamicsConnectionModel
    {
        private string AuthType { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        private string Url { get; set; }
        private string AppId { get; set; }
        private string RedirectURI { get; set; }
        private string LoginPrompt { get; set; }
        public string ConnectionString { get; set; }
        public void BuildConnection()
        {
            AuthType = ConfigurationManager.AppSettings["DynamicsAuthType"];
            UserName = ConfigurationManager.AppSettings["DynamicsUserName"];
            Password = ConfigurationManager.AppSettings["DynamicsPassword"];
            Url = ConfigurationManager.AppSettings["DynamicsUrl"];
            AppId = ConfigurationManager.AppSettings["DynamicsAppId"];
            RedirectURI = ConfigurationManager.AppSettings["DynamicsRedirectURI"];
            LoginPrompt = ConfigurationManager.AppSettings["DynamicsLoginPrompt"];

            ConnectionString = $"AuthType = {AuthType};Username={UserName};Password={Password};Url={Url}; AppId={AppId};RedirectUri={RedirectURI}; LoginPrompt={LoginPrompt}";
        }
    }
}