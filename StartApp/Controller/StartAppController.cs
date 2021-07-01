using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StartApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StartAppController : ControllerBase
    {
        // GET api/<StartAppController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id == 1) {
                Process.Start("notepad");
            }
            if (id == 2) {
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            }
            return id.ToString();
        }
    }
}
