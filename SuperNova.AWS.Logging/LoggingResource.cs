using Microsoft.Extensions.Logging;
using System.Composition;
using SuperNova.AWS.Logging.Contract;
using SuperNova.MEF.NetCore;

namespace SuperNova.AWS.Logging
{
    public class LoggingResource
    {
        [Import]
        private IServiceLoggerFactory LogFactory { get; set; } = null;

        private ILogger _logger = null;
        private string _name;
        protected ILogger Logger => _logger ?? (_logger = LogFactory.GetLogger(_name));

        protected LoggingResource(string name)
        {
            _name = name;
            MEFLoader.SatisfyImportsOnce(this);
        }
    }
}
