using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rosca_Theodora_MOutlet.Data;
using Rosca_Theodora_MOutlet.Models;

namespace Rosca_Theodora_MOutlet.Pages.Products
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
            ViewData["CompanyID"] = new SelectList(_context.Set<Company>(), "ID", "CompanyName");
            ViewData["ProductCategories"] = new SelectList(_context.Set<ProductCategory>(), "ID", "ProductCategories");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
