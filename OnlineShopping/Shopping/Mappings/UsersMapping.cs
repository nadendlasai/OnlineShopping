using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopping.Shopping.Entities;

namespace OnlineShopping.Shopping.Mappings
{
    public class UsersMapping : IEntityTypeConfiguration<UsersEntity>
    {
        public void Configure(EntityTypeBuilder<UsersEntity> builder)
        {
            builder.ToTable("Users", "Auth");

            builder.Property(u => u.Id);
            builder.Property(u => u.Email);
            builder.Property(u => u.UserName);
            builder.Property(u => u.PasswordHash);
            builder.Property(u => u.CreatedAt);
            builder.Property(u => u.IsActive);
        }
    }
}
