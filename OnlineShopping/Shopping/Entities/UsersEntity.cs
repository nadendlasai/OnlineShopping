namespace OnlineShopping.Shopping.Entities
{
    public class UsersEntity
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
