using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoreCrud.Models;


namespace CoreCrud.Pages
{
 
        public class IndexModel : PageModel
        {

            private CoreCrudContext _context;

            public IndexModel(CoreCrudContext context)
            {
                _context = context;
            }
            public int CountOfCountries { get; set; }
            public int CountOfDestinations { get; set; }
            public int DestinationsWithDivesites { get; set; }
            public int DestinationsWithParks { get; set; }
        public void OnGet()
            {

            CountOfCountries = _context.Country.Count();
            CountOfDestinations = _context.Destination.Count();
            DestinationsWithDivesites = _context.Destination
                                        .Where(x => x.DiveSites != null)
                                        .Count();
            DestinationsWithParks = _context.Destination
                                        .Where(x => x.NationalParks != null)
                                        .Count();
        }
        }
}