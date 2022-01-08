using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rosca_Theodora_MOutlet.Data;
using Rosca_Theodora_MOutlet.Models;

namespace Rosca_Theodora_MOutlet.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly Rosca_Theodora_MOutlet.Data.Rosca_Theodora_MOutletContext _context;

        public DetailsModel(Rosca_Theodora_MOutlet.Data.Rosca_Theodora_MOutletContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company.FirstOrDefaultAsync(m => m.ID == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
