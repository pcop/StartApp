using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StartApp.Pages
{
    public class IndexModel : PageModel
    {
        public string BasePath {
            get {
                return System.Environment.CurrentDirectory;
            }
        }
        public void OnGet()
        {
        }
    }
}
