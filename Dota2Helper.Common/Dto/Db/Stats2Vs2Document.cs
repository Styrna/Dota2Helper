using System.Collections.Generic;

namespace Dota2Helper.Common.Dto.Db
{
    public class Stats2Vs2Document
    {
        public int Rad1 { get; set; }
        
        public int Rad2 { get; set; }
        
        public int Dire1 { get; set; }
        
        public int Dire2 { get; set; }

        public IList<HeroStatData> HeroStats { get; set; }
    }
}
