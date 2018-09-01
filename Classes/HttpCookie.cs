using System.Collections.Generic;
using System.Security.AccessControl;

namespace Classes
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;//<key type, value type>
        public DateTime Expiry { get; set; }

        
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }



        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
