using BulldogsPortal.Data;
using BulldogsPortal.Models.Domain;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulldogsPortal.Pages
{
    public class RSVPModel : PageModel
    {
        private readonly RSVPDbContext rsvpDbContext;

        [BindProperty]
        public RSVP AddRSVP { get; set; }

        public RSVPModel(RSVPDbContext rsvpDbContext)
        {
            this.rsvpDbContext = rsvpDbContext;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var RSVPs = new RSVP()
            {
                Callsign = AddRSVP.Callsign,
                Airframe = AddRSVP.Airframe,
                Confirm = AddRSVP.Confirm,
            };

            await rsvpDbContext.RSVPs.AddAsync(RSVPs);
            await rsvpDbContext.SaveChangesAsync();
           
            return RedirectToPage("/List");

            ///GO to another project and look
        }
    }
}
