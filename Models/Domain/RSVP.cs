namespace BulldogsPortal.Models.Domain
{
    public class RSVP
    {
        public Guid Id { get; set; }
        public string Callsign { get; set; }
        public string Airframe { get; set;}
        public bool Confirm { get; set;}

    }
}
