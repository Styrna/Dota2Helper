using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2Helper.Common
{
    public class HeroStatData
    {
        public int HeroId { get; set; }

        public int Wins { get; set; }

        public int Looses { get; set; }

        public static IList<HeroStatData> GetStatList()
        {
            var statList = new List<HeroStatData>();
            for(int i=0;i<Constraints.HeroCount;i++)
                statList.Add(new HeroStatData()
                {
                    HeroId = i,
                    Wins = 0,
                    Looses = 0
                });
            return statList;
        }
    }
}
