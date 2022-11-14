using BulldogsPortal.Data;
using BulldogsPortal.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulldogsPortal.Pages
{
    public class ListModel : PageModel
    {

        private readonly RSVPDbContext rsvpDbContext;
        public List<RSVP> RSVPs { get; set; }

        public ListModel(RSVPDbContext rsvpDbContext)
        {
            this.rsvpDbContext = rsvpDbContext;
        }
        public void OnGet()
        {


            RSVPs = rsvpDbContext.RSVPs.ToList();
        }



    }
}
