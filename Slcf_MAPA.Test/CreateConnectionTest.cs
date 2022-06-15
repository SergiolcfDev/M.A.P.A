using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Slcf_MAPA.Connector;
using Slcf_MAPA.Dynamics.Model;

namespace Slcf_MAPA.Test
{
    [TestClass]
    public class CreateConnectionTest
    {

        DynamicsConnectionModel _ConnectionString;

        public DynamicsConnectionModel DynamicsConnectionModel
        {
            get
            {
                _ConnectionString = new DynamicsConnectionModel();
                return _ConnectionString;
            }
        }
        public Connect365 ConnectService
        {
            get
            {
                return new Connect365(DynamicsConnectionModel.ConnectionString);

            }
        }
        [TestMethod]
        public void CreateConnection()
        {
            var connectionService = ConnectService.GetConnection();
        }
    }
}
