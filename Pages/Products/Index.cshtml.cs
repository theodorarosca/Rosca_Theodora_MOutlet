﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rosca_Theodora_MOutlet.Data;
using Rosca_Theodora_MOutlet.Models;

namespace Rosca_Theodora_MOutlet.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Rosca_Theodora_MOutlet.Data.Rosca_Theodora_MOutletContext _context;

        public IndexModel(Rosca_Theodora_MOutlet.Data.Rosca_Theodora_MOutletContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(b => b.Company)
                .ToListAsync();
        }
    }
}
