using NetTopologySuite.Geometries;

namespace ConditionalCompilation
{
    public partial class Venue
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public Geometry Location { get; set; }
    }
}