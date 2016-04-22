using System;
using Dota2Helper.Common;

namespace Dota2Helper.Bootstrap
{
    public static class CombinationRunner
    {
        public static void Run1Vs1(Action<int, int> action)
        {
            for (var rad1 = 0; rad1 < Constraints.HeroCount; rad1++)
            {
                for (var dire1 = 0; dire1 < Constraints.HeroCount; dire1++)
                {
                    if (dire1 == rad1)
                        continue;

                    action.Invoke(rad1,dire1);
                }
            }
        }

        public static void Run2Vs2(Action<int,int,int,int> action)
        {
            for (var rad1 = 0; rad1 < Constraints.HeroCount - 1; rad1++)
            {
                for (var rad2 = rad1 + 1; rad2 < Constraints.HeroCount; rad2++)
                {
                    for (var dire1 = 0; dire1 < Constraints.HeroCount - 1; dire1++)
                    {
                        if(dire1 == rad1 || dire1 == rad2)
                            continue;

                        for (var dire2 = dire1 + 1; dire2 < Constraints.HeroCount; dire2++)
                        {
                            if (dire2 == rad1 || dire2 == rad2)
                                continue;

                            action.Invoke(rad1, rad2, dire1, dire2);
                        }
                    }
                }
            }
        }
    }
}
