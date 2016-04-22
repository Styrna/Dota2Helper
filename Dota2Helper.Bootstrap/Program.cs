using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dota2Helper.Common;
using log4net;
using MongoDB.Driver;

namespace Dota2Helper.Bootstrap
{
    class Program
    {
        private static readonly ILog Logger = LoggerFactory.CreateLogger(typeof(Program));

        static void Main(string[] args)
        {
            Logger.Info("START");

            var mongoClinet = new MongoClient();
            var mongoDB = mongoClinet.GetDatabase(Constraints.DataBaseName);
            var mongoBootstrapper = new MongoCombinationBootstraper(mongoDB);

            mongoBootstrapper.Initialize1Vs1();


            Logger.Info("END");
        }
    }
}
