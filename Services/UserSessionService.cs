namespace EventEase.Services
{
    public class UserSessionService
    {
        public string? CurrentUserName { get; set; }
        public string? CurrentUserEmail { get; set; }
        public bool IsRegistered => !string.IsNullOrEmpty(CurrentUserName) && !string.IsNullOrEmpty(CurrentUserEmail);

        public void RegisterUser(string name, string email)
        {
            CurrentUserName = name;
            CurrentUserEmail = email;
        }

        public void Logout()
        {
            CurrentUserName = null;
            CurrentUserEmail = null;
        }
    }
}
