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
    public class MongoCombinationBootstraper
    {
        private static readonly ILog Logger = LoggerFactory.CreateLogger(typeof(MongoCombinationBootstraper));
        private readonly IMongoDatabase _mongoDB;

        public MongoCombinationBootstraper(IMongoDatabase mongoDB)
        {
            _mongoDB = mongoDB;
        }

        public void Initialize1Vs1()
        {
            Logger.Info("Initializing 1vs1 ...");

            var collection1Vs1 = _mongoDB.GetCollection<Stats1Vs1Document>("1vs1");
            var keys = Builders<Stats1Vs1Document>.IndexKeys.Ascending((doc => doc.Rad1)).Ascending(doc => doc.Dire1);
            collection1Vs1.Indexes.CreateOne(keys,new CreateIndexOptions() {Unique = true});
    
            var heroStatList = HeroStatData.GetStatList();
            var counter = 0;

            CombinationRunner.Run1Vs1((rad1, dire1) =>
            {
                var combinationDoc = new Stats1Vs1Document()
                {
                    Rad1 = rad1,
                    Dire1 = dire1,
                    HeroStats = heroStatList
                };
                try
                {
                    collection1Vs1.InsertOne(combinationDoc);
                }
                catch (Exception ex)
                {
                    Logger.Error($"Could not insert combination rad1:{rad1} dire1:{dire1}", ex);
                }
                counter ++;
                if(counter % 1000 == 0)
                    Logger.Debug($"Combination1vs1 conter:{counter}");
            });

            Logger.Info("Initialized 1vs1");
        }
    }
}
