namespace LuPerfect.Settings
{
    public record WebsiteSettings
    {
        [Optional]
        public string? IpAddress { get; set; }

        [Optional]
        public string? Domain { get; set; }
    }
}
