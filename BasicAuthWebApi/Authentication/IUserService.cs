namespace BasicAuthWebApi.Authentication
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }
}
