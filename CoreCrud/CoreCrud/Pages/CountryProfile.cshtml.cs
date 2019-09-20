using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoreCrud.Models;
using Microsoft.EntityFrameworkCore;
namespace CoreCrud.Pages
{
    public class CountryProfileModel : PageModel
    {
        private CoreCrudContext _context;
        public CountryProfileModel(CoreCrudContext context)
        {
            _context = context;
        }
        public Country Country { get; set; }
        public IActionResult OnGet(int? id)

        {
            if (id == null)
            {
                return NotFound();
            }

            Country = _context.Countries
                                .Include(x => x.CountryName)
                                .FirstOrDefault(cty => cty.ID == id);
            return Page();
        }
    }
}