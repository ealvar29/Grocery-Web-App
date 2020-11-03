using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grocer.ly.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grocer.ly.Pages
{
    public class IndexModel : PageModel
    {
        public List<GroceryItem> Foods = Inventory.ToList();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}