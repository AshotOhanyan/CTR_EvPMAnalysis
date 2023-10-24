using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTR_EvPMAnalysis.Models
{
    public class ImpressionLog
    {
        public DateTime RegTime { get; set; }
        public string Uid { get; set; }
        public int FcImpCheck { get; set; }
        public int FcTimeCheck { get; set; }
        public int Utmtr { get; set; }
        public string MmDma { get; set; }
        public string OsName { get; set; }
        public string Model { get; set; }
        public string Hardware { get; set; }
        public string SiteId { get; set; }
    }
}
