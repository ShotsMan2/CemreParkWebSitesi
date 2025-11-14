namespace TanıtımWebSitesi.Models
{
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor HttpContextAccessor;

        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public string GetString(string key)
        {
            return HttpContextAccessor.HttpContext.Session.GetString(key);
        }

        public void SetString(string key, string value)
        {
            HttpContextAccessor.HttpContext.Session.SetString(key, value);
        }
    }
}
