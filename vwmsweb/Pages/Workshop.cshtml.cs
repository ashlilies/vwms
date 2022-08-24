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
    public class WorkshopModel : PageModel
    {
        private readonly vwmsweb.Models.VwmsContext _context;

        public WorkshopModel(vwmsweb.Models.VwmsContext context)
        {
            _context = context;
        }

        public IList<Workshop> Workshop { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Workshops != null)
            {
                Workshop = await _context.Workshops
                .Include(w => w.Category)
                .Include(w => w.Exhibitor)
                .Include(w => w.Saloon)
                .Include(w => w.Status)
                .Include(w => w.Time).ToListAsync();
            }
        }
    }
}
