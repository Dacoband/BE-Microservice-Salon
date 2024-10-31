namespace UserService.Models
{
    public class User
    {
        public Guid AccountID { get; set; }
        public string RoleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool DelFlg { get; set; }
    }
}