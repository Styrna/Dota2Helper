using System;
using System.Linq;
using System.Net;
using System.Threading;
using Dota2Helper.Common.Dto.DotaApi;
using Dota2Helper.Common.Log;
using Dota2Helper.Common.Seeding;
using Newtonsoft.Json;

namespace Dota2Helper.Console
{
    class Program
    {
        private static readonly ILog Log = LogFactory.Create(typeof(Program));

        
        static void Main(string[] args)
        {
            Log.Trace("START");
            
            var crawler = new Crawler();
            long lastMatchId = 500;
            while (true)
            {
                var results = crawler.GetMatchHistoryBySequanceNum(lastMatchId, 100);
                lastMatchId = results.matches.OrderByDescending(m => m.match_id).First().match_id;
                Log.Info($"Got mataches {results.matches.Count} lastMatchId:{lastMatchId}");
                Thread.Sleep(5000);
            }

            Log.Trace("END");
            System.Console.ReadLine();
        }
    }
}
