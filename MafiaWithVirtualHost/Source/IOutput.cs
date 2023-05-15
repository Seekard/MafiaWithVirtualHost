using MafiaWithVirtualHost.Source.Game;

namespace MafiaWithVirtualHost.Source;

public interface IOutput
{
    public void SendTurnInfo(Turn turn);
}