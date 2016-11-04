// ReSharper disable InconsistentNaming

using System.Collections.Generic;

namespace Dota2Helper.Common.Dto.DotaApi
{
    public class Match
    {
        public long match_id { get; set; }
        public object match_seq_num { get; set; }
        public long start_time { get; set; }
        public long lobby_type { get; set; }
        public int radiant_team_id { get; set; }
        public int dire_team_id { get; set; }
        public List<Player> players { get; set; }
    }
}
