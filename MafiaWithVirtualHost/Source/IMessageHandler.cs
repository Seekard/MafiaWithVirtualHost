namespace MafiaWithVirtualHost.Source;

public interface IMessageHandler
{
    public void HandleMessage(Message message);
}