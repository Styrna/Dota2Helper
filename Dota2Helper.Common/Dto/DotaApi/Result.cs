// ReSharper disable InconsistentNaming

using System.Collections.Generic;

namespace Dota2Helper.Common.Dto.DotaApi
{
    public class Result
    {
        public int status { get; set; }
        public List<Match> matches { get; set; }
    }
}
