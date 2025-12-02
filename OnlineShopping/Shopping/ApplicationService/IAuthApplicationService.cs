using OnlineShopping.Shopping.ViewModels;

namespace OnlineShopping.Shopping.ApplicationService
{
    public interface IAuthApplicationService
    {
        Task<string> Register(RegisterDto register);
        Task<string> Login(LoginDto login);
    }
}
