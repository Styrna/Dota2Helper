using System.Collections.Generic;

namespace Dota2Helper.Common.Dto.Db
{
    public class Stats1Vs1Document
    {
        public int Rad1 { get; set; }

        public int Dire1 { get; set; }
        
        public IList<HeroStatData> HeroStats { get; set; }
    }
}
