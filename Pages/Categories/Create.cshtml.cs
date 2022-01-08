using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rosca_Theodora_MOutlet.Data;
using Rosca_Theodora_MOutlet.Models;

namespace Rosca_Theodora_MOutlet.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Rosca_Theodora_MOutlet.Data.Rosca_Theodora_MOutletContext _context;

        public CreateModel(Rosca_Theodora_MOutlet.Data.Rosca_Theodora_MOutletContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
