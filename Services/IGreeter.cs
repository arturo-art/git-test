namespace EmptyCore.Services
{
    public interface IGreeter
    {
        string GetMessageOfDay();
    }

    public class Greeter : IGreeter
    {
        public string GetMessageOfDay()
        {
            return "Message Of Day From Interface";
        }
    }
}