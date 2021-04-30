namespace RaidManager.Domain.Dto.Authentication
{
    /// <summary>
    /// Dto model for a login request
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// User name (can be alias or email)
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value></value>
        public string Password { get; set; }
    }
}