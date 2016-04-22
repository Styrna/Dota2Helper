using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2Helper.Common
{
    public class Stats1Vs1Document
    {
        public int Rad1 { get; set; }

        public int Dire1 { get; set; }
        
        public IList<HeroStatData> HeroStats { get; set; }
    }
}
