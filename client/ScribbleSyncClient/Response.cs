using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScribbleSyncClient
{
    class Response
    {
        public int statuscode { get; set; }
        public string message { get; set; }

        public string app_message { get; set; }

        public string token { get; set; }
        public string content { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string avatar { get; set; }
        public string data { get; set; }
        public int id { get; set; }
        public List<string> share_list { get; set; }
        public noteIds id_list { get; set; }
        public templateItem template { get; set; }
        public List<templateItem> items { get; set; }

        public string share_token { get; set; }
    }
}
