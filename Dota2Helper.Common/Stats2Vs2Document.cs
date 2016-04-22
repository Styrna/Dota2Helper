using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Dota2Helper.Common
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
