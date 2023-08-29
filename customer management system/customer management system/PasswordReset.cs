using System;

namespace customer_management_system
{
    public class PasswordReset
    {
        // Fields
        private string username;
        private string email;
        private string newPassword;

        // Constructor
        public PasswordReset(string username, string email)
        {
            this.username = username;
            this.email = email;
        }

        //properties
        public string Username1 { get => username; set => username = value; }
        public string Email1 { get => email; set => email = value; }
        public string NewPassword1 { get => newPassword; set => newPassword = value; }

        public void SendPasswordResetLink()
        {
            Console.WriteLine($"Password reset link sent to {email} for username {username}");
        }
        public void UpdatePassword()
        {
            Console.WriteLine($"Password updated for username {username}");
        }
    }
}
