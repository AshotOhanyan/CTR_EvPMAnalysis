using CTR_EvPMAnalysis.Models;

namespace CTR_EvPMAnalysis.Services
{
    public class DataProcessor
    {


        public double CalculateCTR(List<ImpressionLog> impressionLogs, List<EventLog> eventLogs)
        {
            int clickCount = eventLogs.Count(e => !e.Tag.StartsWith("<v>"));
            int impressionCount = impressionLogs.Count;

            if (impressionCount == 0)
            {
                return 0; 
            }

            double ctr = (double)clickCount / impressionCount * 100;
            return ctr;
        }

        public double CalculateEvPM(List<ImpressionLog> impressionLogs, List<EventLog> eventLogs, string eventType)
        {
            int eventCount = eventLogs.Count(e => e.Tag == eventType);
            int impressionCount = impressionLogs.Count;

            if (impressionCount == 0)
            {
                return 0; 
            }

            double evpm = (double)eventCount / impressionCount * 1000;
            return evpm;
        }
    }

}
