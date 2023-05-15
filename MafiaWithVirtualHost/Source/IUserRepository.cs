namespace MafiaWithVirtualHost.Source;

public interface IUserRepository
{
    public UserInfo GetUser(int id);
    public void AddUser(IUser user);
}
