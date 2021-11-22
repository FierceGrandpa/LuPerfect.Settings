namespace LuPerfect.Settings
{
    public record ServerSettings
    {
        [Optional]
        public string? IpAddress { get; init; }

        [Optional]
        public string? Domain { get; init; }
    }
}
