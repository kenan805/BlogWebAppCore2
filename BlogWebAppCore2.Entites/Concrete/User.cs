using BlogWebAppCore2.Shared.Entites.Abstract;

namespace BlogWebAppCore2.Entites.Concrete
{
    public class User : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string Picture{ get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}