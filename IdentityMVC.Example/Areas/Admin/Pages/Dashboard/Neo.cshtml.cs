using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityMVC.Example.Areas.Admin.Pages.Dashboard
{
    [AllowAnonymous]
    public class NeoModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
