namespace LuPerfect.Settings
{
    public record CacheSettings
    {
        [Optional]
        public string? RedisUrl { get; init; } = null;
    }
}
