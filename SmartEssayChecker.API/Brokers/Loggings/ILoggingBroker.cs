namespace SmartEssayChecker.API.Brokers.Loggings;

public interface ILoggingBroker
{
    public void LogCritical(Exception exception);
    public void LogError(Exception exception);
}