using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternMyExample
{
    internal class LoadBalancer
    {
        #region Attributes

        private List<string> servers;

        private static LoadBalancer instance;
        private static readonly object syncLock = new object();

        #endregion // !Attributes

        #region Singleton Util
        private LoadBalancer()
            => servers = new List<string>();

        public static LoadBalancer Instance
        {
            get
            { 
                if (instance == null)
                    lock (syncLock)
                        if (instance == null)
                            instance = new LoadBalancer();
                return instance;
            }
        }

        #endregion // !Singleton Util

        #region Business Logic
        public string RandomServer
        {
            get 
            {
                Random rand = new Random();
                return servers[rand.Next() % servers.Count];
            }
        }

        public string NewServer
        { set => servers.Add(value); }

        public void Clear() => servers.Clear();
        #endregion // !Business Logic

    }
}
