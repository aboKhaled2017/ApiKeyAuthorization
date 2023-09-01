namespace ApiKeyAuth.FakeDatabase
{
    public interface IFakeDatabase
    {
        string GetApiKey();
    }

    public class FakeDatabase : IFakeDatabase
    {
        public string GetApiKey()
        {
            return "abc";
        }
    }
}
