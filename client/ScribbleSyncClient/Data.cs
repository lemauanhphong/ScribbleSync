using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScribbleSyncClient
{
    class Data
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string content { get; set; }
        public string share_add { get; set; }
        public string share_remove { get; set; }
        public bool? share_token { get; set; }
        public string new_password { get; set; }
        public string new_avatar { get; set; }
        public string filename { get; set; }

    }
}
