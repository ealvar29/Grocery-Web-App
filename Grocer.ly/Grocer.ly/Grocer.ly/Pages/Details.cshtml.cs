using System.Collections.Generic;
using Grocer.ly.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grocer.ly.Pages
{
    public class Details : PageModel
    {
        public List<GroceryItem> Foods = Inventory.ToList();
        public GroceryItem CurrentFood;
        
        public void OnGet(string name)
        {
           CurrentFood = Foods.Find(x => x.Name.Trim().ToLower() == name.Trim().ToLower());
        }
    }
}