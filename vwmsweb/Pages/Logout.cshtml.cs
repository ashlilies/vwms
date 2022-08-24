using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vwmsweb.Utils;

namespace vwmsweb.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            SessionUtil.RemoveUser(HttpContext);
            return RedirectToPage("Index");
        }
    }
}
