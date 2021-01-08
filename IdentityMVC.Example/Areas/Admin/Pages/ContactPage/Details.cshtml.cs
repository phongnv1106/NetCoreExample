using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityMVC.Example.Data;
using IdentityMVC.Example.Data.Entities;

namespace IdentityMVC.Example.Areas.Admin.Pages.ContactPage
{
    public class DetailsModel : PageModel
    {
        private readonly IdentityMVC.Example.Data.ApplicationDbContext _context;

        public DetailsModel(IdentityMVC.Example.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contacts.FirstOrDefaultAsync(m => m.ContactId == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
