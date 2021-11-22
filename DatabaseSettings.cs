namespace LuPerfect.Settings
{
    public record DatabaseSettings
    {
        [Optional]
        public string? Provider { get; init; } = "mssql";
        [Optional]
        public string? ConnectionString { get; init; } = null;
    }
}