namespace GoldenEye.Shared.Core.Utils.MessageBus
{
    public interface IMessageHandler<TMessage> where TMessage : class, IMessage, new()
    {
        void HandleMessage(TMessage message);
    }
}
