using System;

namespace SemgrepTestProject.Services
{
    public class AuthService
    {
        public bool ValidateUser(string username, string password)
        {
            // Hardcoded password (Vulnerability)
            if (username == "admin" && password == "password123")
            {
                return true;
            }
            return false;
        }
    }
}
