using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Slcf_MAPA.Connector;
using Slcf_MAPA.Dynamics.Model;

namespace Slcf_MAPA.Test
{
    [TestClass]
    public class CreateConnectionTest
    {

        string _ConnectionString;

        public string DynamicsConnectionModel
        {
            get
            {
                var dynamicsConnectionModel = new DynamicsConnectionModel();
                dynamicsConnectionModel.BuildConnection();
                return dynamicsConnectionModel.ConnectionString;
            }
        }

        Connect365 _service;

        public Connect365 ConnectService
        {
            get
            {
                _service = new Connect365(_ConnectionString);
                return _service;
            }
        }

     
        [TestMethod]
        public void CreateConnection()
        {
            var connectionstringx = DynamicsConnectionModel;
            var teste = _service.GetConnection();
        }
    }
}
