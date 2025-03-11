using Microsoft.AspNetCore.Identity;

namespace Medical.Core.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Chat> Chats { get; set; }
    }
}
