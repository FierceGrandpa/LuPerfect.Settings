using System.ComponentModel.DataAnnotations;

namespace LuPerfect.Settings
{
    public record JwtSettings
    {
        private string key = string.Empty;
        private string issuer = string.Empty;
        private string audience = string.Empty;

        [Required, MinLength(10)]
        public string Key 
        {
            get
            {
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentNullException(nameof(key));
                return key;
            }
            init
            {
                if (string.IsNullOrEmpty(value))
                   throw new ArgumentNullException(nameof(value));
                key = value;
            }
        }

        [Required, MinLength(10)]
        public string Issuer
        {
            get
            {
                if (string.IsNullOrEmpty(issuer))
                    throw new ArgumentNullException(nameof(issuer));
                return issuer;
            }
            init
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(value));
                issuer = value;
            }
        }

        [Required, MinLength(1)]
        public string Audience
        {
            get
            {
                if (string.IsNullOrEmpty(audience))
                    throw new ArgumentNullException(nameof(audience));
                return audience;
            }
            init
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(value));
                audience = value;
            }
        }

        [Optional]
        [Range(1, 60 * 24)]
        public int TokenExpirationInMinutes { get; init; } = 15;

        [Optional]
        [Range(14, 365)]
        public int RefreshTokenExpirationInDays { get; init; } = 14;
    }
}