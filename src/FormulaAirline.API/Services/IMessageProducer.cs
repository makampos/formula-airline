namespace FormulaAirline.API.Services;

public interface IMessageProducer
{
    public void SendingMessages<T>(T message);
}