
using CsvHelper.Configuration;
using CTR_EvPMAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTR_EvPMAnalysis.Mappings
{
    public sealed class ImpressionLogMap : ClassMap<ImpressionLog>
    {
        public ImpressionLogMap()
        {
            Map(m => m.RegTime).Name("reg_time");
            Map(m => m.Uid).Name("uid");
            Map(m => m.FcImpCheck).Name("fc_imp_chk");
            Map(m => m.FcTimeCheck).Name("fc_time_chk");
            Map(m => m.Utmtr).Name("utmtr");
            Map(m => m.MmDma).Name("mm_dma");
            Map(m => m.OsName).Name("osName");
            Map(m => m.Model).Name("model");
            Map(m => m.Hardware).Name("hardware");
            Map(m => m.SiteId).Name("site_id");
        }
    }

    public sealed class EventLogMap : ClassMap<EventLog>
    {
        public EventLogMap()
        {
            Map(m => m.Uid).Name("uid");
            Map(m => m.Tag).Name("tag");
        }
    }
}
