using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Pattern04_Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        // Constructor is protected
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Lazy initialization. Not thread-safe
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
