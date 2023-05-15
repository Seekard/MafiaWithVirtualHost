namespace MafiaWithVirtualHost.Source;

public interface IClient
{
    public event Action<Message> MessageReceived;
    public void SendMessage(IUser user);
    public void SendGroupMessage(IEnumerable<IUser> users);
}