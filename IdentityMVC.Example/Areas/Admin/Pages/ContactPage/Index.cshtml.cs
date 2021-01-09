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
using IdentityMVC.Example.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityMVC.Example.Areas.Admin.Pages.ContactPage
{
    [Authorize]
    public class IndexModel : PageModel
    {
 
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAuthorizationService _authorizationService;
        //public IndexModel(           
        //    ApplicationDbContext context,
        //    IAuthorizationService authorizationService,
        //    UserManager<IdentityUser> userManager) : base(context, authorizationService, userManager)
        //{
        //    _context = context;

        //}
        public IndexModel(
                ApplicationDbContext context,
                IAuthorizationService authorizationService,
                UserManager<IdentityUser> userManager)
            : base()
        {
            _context = context;
            _userManager = userManager;
            _authorizationService = authorizationService;

        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            
            var contacts = from c in _context.Contacts
                           select c;




            bool x1 = User.IsInRole(Constants.ContactManagersRole);
            bool x2 = User.IsInRole(Constants.ContactAdministratorsRole);
            var isAuthorized = x1 || x2;

            var currentUserId = _userManager.GetUserId(User);

            // Only approved contacts are shown UNLESS you're authorized to see them
            // or you are the owner.
            if (!isAuthorized)
            {
                contacts = contacts.Where(c => c.Status == ContactStatus.Approved
                                            || c.OwnerID == currentUserId);
            }

            Contact = await contacts.ToListAsync();

            // Contact = await _context.Contacts.ToListAsync();

        }
    }
}
