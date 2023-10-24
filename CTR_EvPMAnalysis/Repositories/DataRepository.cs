using CsvHelper.Configuration;
using CsvHelper;
using CTR_EvPMAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTR_EvPMAnalysis.Mappings;

namespace CTR_EvPMAnalysis.Data.Repositories
{
    public class DataRepository
    {
        private readonly string impressionLogFilePath;
        private readonly string eventLogFilePath;

        public DataRepository(string impressionLogFilePath,string eventLogFilePath)
        {
            this.impressionLogFilePath = impressionLogFilePath;
            this.eventLogFilePath = eventLogFilePath;
        }

        public List<ImpressionLog> GetAllImpressions()
        {
            using (var reader = new StreamReader(impressionLogFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                // Map CSV columns to ImpressionLog properties
                csv.Context.RegisterClassMap<ImpressionLogMap>();

                return csv.GetRecords<ImpressionLog>().ToList();
            }
        }

        public List<EventLog> GetAllEvents()
        {
            using (var reader = new StreamReader(eventLogFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                // Map CSV columns to EventLog properties
                csv.Context.RegisterClassMap<EventLogMap>();

                return csv.GetRecords<EventLog>().ToList();
            }
        }
    }

}

