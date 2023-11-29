namespace PathOfExileStarter.Domain.Services.Interfaces
{
    internal interface IAuthService
    {
        public bool IsAuthenticated();

        public void FetchToken();

        public void Logout();
    }
}
