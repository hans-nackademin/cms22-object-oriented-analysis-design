using _05_DIP.Models.BaseModels;

namespace _05_DIP.Models.Entities
{
    public class UserEntity : User
    {
        public int Id { get; set; }
        public byte[] PHash { get; set; } = null!;
        public byte[] PKey { get; set; } = null!;


    }
}
