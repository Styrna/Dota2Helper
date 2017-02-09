// ReSharper disable InconsistentNaming

using System.Collections.Generic;

namespace Dota2Helper.Common.Dto.DotaApi
{
    public class Match
    {
        public long match_id { get; set; }
        public bool radiant_win { get; set; }
        public long start_time { get; set; }
        public int lobby_type { get; set; }
        public int human_players { get; set; }
        public int game_mode { get; set; }
        public List<Player> players { get; set; }
    }
}
