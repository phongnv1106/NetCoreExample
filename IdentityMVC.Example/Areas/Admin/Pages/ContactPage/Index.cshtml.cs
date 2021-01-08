using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityMVC.Example.Data;
using IdentityMVC.Example.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace IdentityMVC.Example.Areas.Admin.Pages.ContactPage
{
    [Authorize]
    public class IndexModel : PageModel
    {
 
        private readonly IdentityMVC.Example.Data.ApplicationDbContext _context;

        public IndexModel(
           
            ApplicationDbContext context)
        {
            _context = context;
           
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
           
            Contact = await _context.Contacts.ToListAsync();
          
        }
    }
}
