using System;

namespace CampusResolve
{
    public static class SessionManager
    {
        public static int UserId { get; set; } = -1;
        public static string Username { get; set; } = string.Empty;
        public static string Role { get; set; } = string.Empty;

        public static void ClearSession()
        {
            UserId = -1;
            Username = string.Empty;
            Role = string.Empty;
        }

        public static bool IsLoggedIn()
        {
            return UserId != -1;
        }
    }
}
