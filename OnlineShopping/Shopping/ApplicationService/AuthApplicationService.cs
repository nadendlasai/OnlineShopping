using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Shopping.Context;
using OnlineShopping.Shopping.Entities;
using OnlineShopping.Shopping.ViewModels;

namespace OnlineShopping.Shopping.ApplicationService
{
    public class AuthApplicationService : IAuthApplicationService
    {
        private readonly ShoppingContext _shoppingContext;
        public AuthApplicationService(ShoppingContext shoppingContext)
        {
            _shoppingContext = shoppingContext;
        }

        public async Task<string> Login(LoginDto login)
        {
            var user = await _shoppingContext.usersEntities.FirstOrDefaultAsync(u => u.Email == login.Email);
            if (user == null)
                throw new Exception("Invalid email or password");

            var ok = BCrypt.Net.BCrypt.Verify(login.Password, user.PasswordHash);
            if (!ok)
                throw new Exception("Invalid email or password");

            return "Login success";
        }

        public async Task<string> Register(RegisterDto register)
        {
            if (register.Email == null)
                throw new Exception("Email is required");

            var emailExists = await _shoppingContext.usersEntities.FirstOrDefaultAsync(x => x.Email == register.Email);
            if (emailExists != null)
                throw new Exception("Email already registered");

            if (register.UserName == null)
                throw new Exception("UserName is required");

            if (register.Password == null)
                throw new Exception("Password is required");

            var user = new UsersEntity
            {
                Email = register.Email,
                UserName = register.UserName,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(register.Password),
                CreatedAt = DateTime.Now,
                IsActive = true
            };
            _shoppingContext.usersEntities.Add(user);
            await _shoppingContext.SaveChangesAsync();
            return "Registered successfully!";
        }
    }
}
