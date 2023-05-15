namespace MafiaWithVirtualHost.Source.Game;

public interface IMafiaGame
{
    public event Action<Turn> TurnSwitched;
}