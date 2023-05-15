using MafiaWithVirtualHost.Source.Game;

namespace MafiaWithVirtualHost.Source;

public class UserInfo
{
    public IUser User { get; }
    public Player? Player { get; private set; }
    public Match? Match { get; private set; }
    
    public UserInfo(IUser user)
    {
        User = user;
    }

    public void SetMatchInfo(Match match, Player player)
    {
        Match = match;
        Player = player;
    }

    public void ClearMatchInfo()
    {
        Match = null;
        Player = null;
    }
}