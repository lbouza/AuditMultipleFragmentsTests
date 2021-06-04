namespace DBService.Domain.Inheritance
{
    public abstract class MiddleTwo : Root
    {
        public bool? IncludePendingResults { get; set; }

        public bool? IncludeStandardTests { get; set; }
        public bool? IncludeMicrobiologyTests { get; set; }
        public bool? IncludeToxicologyTests { get; set; }
        public bool? IncludePathologyTests { get; set; }
    }
}
