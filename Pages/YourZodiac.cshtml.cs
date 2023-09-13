//Dao Nguyet Nu Trinh_A01268847
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab1.Models;

namespace Lab1.Pages
{
    public class YourZodiacModel : PageModel
    {
        [BindProperty]
        public Utils? Utils {get; set;}
        public void OnGet()
        {
            ViewData["YZ"] = "";
        }

        public void OnPost() {
            if(int.TryParse(Request.Form["year"], out int inputYear)) {
                ViewData["Year"] = inputYear;
                if(inputYear < 1900 || inputYear > DateTime.Now.Year)
                {
                    ViewData["Error"] = "Year must be between 1900 and the next. Try again";
                }
                else {
                    
                    ViewData["YZ"] = Utils.GetZodiac(inputYear);
                }
            }
           
        }
    }
}
