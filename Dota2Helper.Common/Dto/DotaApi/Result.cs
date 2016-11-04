// ReSharper disable InconsistentNaming

using System.Collections.Generic;

namespace Dota2Helper.Common.Dto.DotaApi
{
    public class Result
    {
        public int status { get; set; }
        public int num_results { get; set; }
        public int total_results { get; set; }
        public int results_remaining { get; set; }
        public List<Match> matches { get; set; }
    }
}
