using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vwmsweb.Models;

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

        public async Task OnGetAsync()
        {
            if (_context.Surveys != null)
            {
                Survey = await _context.Surveys.ToListAsync();
            }
        }
    }
}
