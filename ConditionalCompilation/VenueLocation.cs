namespace ConditionalCompilation
{
#if EXCLUDE_VENUE_LOCATION
    public partial class Venue
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public Geometry Location { get; set; }
    }
#endif
}