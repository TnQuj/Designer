using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real04_Singleton
{
    public class LoadBalancer
    {
        private static LoadBalancer _instance;
        private static readonly object syncLock = new object();

        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        // Constructor protected
        protected LoadBalancer()
        {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Double-checked locking for thread safety
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }
            return _instance;
        }

        public string Server => _servers[_random.Next(_servers.Count)];
    }
}
