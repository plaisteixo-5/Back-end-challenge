namespace Domain.ValueObjects
{
    public class Location
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostCode { get; private set; }
        public Cordinates Cordinates { get; private set; }
        public TimeZone TimeZone { get; private set; }
    }
}