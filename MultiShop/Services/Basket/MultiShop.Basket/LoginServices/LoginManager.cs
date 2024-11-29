namespace MultiShop.Basket.LoginServices
{
    public class LoginManager : ILoginService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
    }
}
