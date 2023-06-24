using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScribbleSyncClient
{
    class Request
    {
        public string action { get; set; }
        public Data data { get; set; }
        public string token { get; set; }

    }
}
