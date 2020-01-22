namespace Game.ActorModel.Messages
{
    public class JoinGameMessages
    {
        public string PlayerName { get; private set; }
        public JoinGameMessages(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
