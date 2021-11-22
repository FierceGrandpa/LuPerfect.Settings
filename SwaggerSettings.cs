namespace LuPerfect.Settings
{
    public record SwaggerSettings
    {
        [Optional]
        public bool Enable { get; init; } = false;
    }
}