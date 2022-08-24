using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vwmsweb.Models;
using vwmsweb.Utils;

namespace vwmsweb.Pages
{
    public class SurveyModel : PageModel
    {
        private readonly vwmsweb.Models.VwmsContext _context;

        public SurveyModel(vwmsweb.Models.VwmsContext context)
        {
            _context = context;
        }

        public IList<Survey> Survey { get;set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            if (!SessionUtil.Authorize(HttpContext))
            {
                return Redirect(Constants.UnauthorizedRedirect);
            }
            
            if (_context.Surveys != null!)
            {
                Survey = await _context.Surveys.ToListAsync();
            }

            return Page();
        }
    }
}
