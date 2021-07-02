using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartApp
{
    public class ProgConfig
    {
        public Plist[] PList { get; set; }

        public class Plist
        {
            public string fileName { get; set; }
            public string arguments { get; set; }
        }
    }


}


