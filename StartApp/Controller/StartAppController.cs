using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StartApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StartAppController : ControllerBase
    {
        public ProgConfig _ProgConfig { get; set; }


        public StartAppController(IOptions<ProgConfig> ProgConfig) {
            _ProgConfig = ProgConfig.Value;
        }

        // GET api/<StartAppController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (_ProgConfig.PList.Count() <= id)
            {
                return id.ToString();
            }
            Process.Start(_ProgConfig.PList[id]);
            return id.ToString();
        }
    }
}
