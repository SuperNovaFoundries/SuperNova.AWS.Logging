using Microsoft.Extensions.Logging;

namespace SuperNova.AWS.Logging.Contract
{
    public interface IServiceLoggerFactory
    {
        ILogger GetLogger(string category);
    }

}
