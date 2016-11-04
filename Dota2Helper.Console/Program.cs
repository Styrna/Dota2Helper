using System;
using System.Linq;
using System.Net;
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

            var result = crawler.GetMatches();

            while (true)
            {
                Log.Info($"Got mataches {result.num_results}");
                result = crawler.GetNextMatches(result.matches.Last().match_id);
            }
            
            Log.Trace("END");
            System.Console.ReadLine();
        }
    }
}
