using System;
using System.Net;
using Dota2Helper.Common.Dto.DotaApi;
using Dota2Helper.Common.Log;
using Newtonsoft.Json;

namespace Dota2Helper.Common.Seeding
{
    public interface ICrawler
    {
        Result GetMatches();

        Result GetNextMatches(long lastMatchId);
    }

    public class Crawler : ICrawler
    {
        private static readonly ILog Log = LogFactory.Create(typeof(Crawler));

        private const string GetMatchesUrl = "https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/V001/?key=5DAAED5C176A21337D8E46991CE9A48E&";
        private const string NextMatchParam = "start_at_match_id=";
        private const string PlayerConditionParam = "min_players=10";

        public Result GetMatches()
        {
            var client = new WebClient();
            var response = client.DownloadString($"{GetMatchesUrl}&{PlayerConditionParam}");
            return JsonConvert.DeserializeObject<RootObject>(response).result;
        }

        public Result GetNextMatches(long lastMatchId)
        {
            var client = new WebClient();
            var response = client.DownloadString($"{GetMatchesUrl}&{NextMatchParam}{lastMatchId}&{PlayerConditionParam}");
            return JsonConvert.DeserializeObject<RootObject>(response).result;
        }
    }
}
