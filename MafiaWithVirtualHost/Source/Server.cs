using MafiaWithVirtualHost.Source.Game;

namespace MafiaWithVirtualHost.Source;

public class Server
{
    public Server(IMafiaGame mafiaGame, IClient client, IMessageHandler messageHandler, IOutput output)
    {
        mafiaGame.TurnSwitched += HandleTurn;
        client.MessageReceived += HandleMessage;
    }

    private void HandleMessage(Message message)
    {
        throw new NotImplementedException();
    }
    
    private void HandleTurn(Turn turn)
    {
        throw new NotImplementedException();
    }
}