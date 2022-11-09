using System.Data;

namespace Bulldogsportal.Models.Domain
{
    public class RSVP
    {
        public Guid id { get; set; }
        public string Callsign { get; set; }
        private string Email { get; set; }
        public string Airframe { get; set; }
    }
}
