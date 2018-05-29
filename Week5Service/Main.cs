using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5.Persistence;
using Week5Service.Peristence;

namespace Week5Service
{
    class Main
    {
        private static Main instance = null;
        private static readonly object padlock = new object();

        private Main()
        {
            PersistenceService = new PersistenceService(new MongoPersistenceFactory(
                new MlabDB("ds139690.mlab.com", 39690, "week5service", "admin", "hN53YQD9CXgRaJ4N")));
        }

        public static Main Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Main();
                    }
                    return instance;
                }
            }
        }

        public PersistenceService PersistenceService { get; }

    }
}
