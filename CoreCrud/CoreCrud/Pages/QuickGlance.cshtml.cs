using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoreCrud.Models;

namespace CoreCrud.Pages
{
    public class QuickGlanceModel : PageModel
    {
        private CoreCrudContext _context;

        public QuickGlanceModel(CoreCrudContext context) {
            _context = context;
        }

        public List<Destination> Destinations { get; set; }



        public void OnGet()
        {

            Destinations = _context.Destination.OrderBy(x => x.LeaveDate).ToList();

        }
    }

}