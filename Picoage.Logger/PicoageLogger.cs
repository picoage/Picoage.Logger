using Microsoft.Extensions.Logging;

namespace Picoage.Logger
{
    internal class PicoageLogger<T> : IPicoageLogger<T>
    {
        private readonly ILogger logger;

        public PicoageLogger(ILogger<T> logger)
        {
            this.logger = logger;
        }

        public void Critical(string id, Exception exception, string message)
        {
            logger.LogCritical(exception, "Critical event has occured for id:{id} and the message:{message}", id, message);
        }

        public void Error(string id, Exception exception, string message)
        {
            logger.LogError(exception, "Error has occured for id:{id} and the message:{message}", id, message);
        }

        public void Information(string id, string message)
        {

            logger.LogInformation("Information for id:{id} and the message:{message}", id, message);
        }

        public void Warning(string id, string message)
        {

            logger.LogWarning("Warning for id:{id} and the message:{message}", id, message);
        }
    }
}
