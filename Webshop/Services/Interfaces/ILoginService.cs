namespace ASPWebshop.Services.Interfaces
{
    public interface ILoginService
    {
        bool verifyUser(string username, string password);
    }
}