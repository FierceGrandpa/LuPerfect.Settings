namespace LuPerfect.Settings
{
    public record MiddlewareSettings
    {
        [Optional]
        public bool EnableHttpsLogging { get; init; } = false;
        [Optional]
        public bool EnableLocalization { get; init; } = false;
    }
}