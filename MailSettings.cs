namespace LuPerfect.Settings
{
    public record MailSettings
    {
        [Optional]
        public string? DisplayName { get; init; }
        public string? From { get; init; }

        public string? Host { get; init; }
        public int? Port { get; init; }

        public string? Username { get; init; }
        public string? Password { get; init; }

        [Optional]
        public bool EnableVerification { get; init; } = false;
    }
}