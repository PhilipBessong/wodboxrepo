namespace wodapi.Models
{
    public class User
    {
        public int userId { get; set; }
        public string? name { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public string password { get; set; }
        public string? ResetToken { get; set; }
        public DateTime? ResetTokenExpiration { get; set; } // Use DateTime? for nullable DateTime


    }




}
