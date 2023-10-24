using CTR_EvPMAnalysis.Data.Repositories;
using CTR_EvPMAnalysis.Models;
using CTR_EvPMAnalysis.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.ConstrainedExecution;

namespace CTR_EvPMAnalysis.Controllers
{

    public class MetricsController : PageModel
    {
        [BindProperty]
        public ResultsViewModel ResultsModel { get; set; }

        private readonly DataProcessor _dataProcessor;
        private readonly DataRepository _dataRepository;

        public MetricsController(DataProcessor dataProcessor, DataRepository dataRepository)
        {
            _dataProcessor = dataProcessor;
            _dataRepository = dataRepository;
        }

        public IActionResult OnGet()
        {
            // Load your data (impressionLogs and eventLogs) from your DataRepository
            List<ImpressionLog> impressionLogs = _dataRepository.GetAllImpressions();
            List<EventLog> eventLogs = _dataRepository.GetAllEvents();

            // Calculate CTR and EvPM
            double ctr = _dataProcessor.CalculateCTR(impressionLogs, eventLogs);
            double evpm = _dataProcessor.CalculateEvPM(impressionLogs, eventLogs, "fclick");

            // Create a ResultsViewModel to pass the results to the view
            ResultsModel = new ResultsViewModel
            {
                CTR = ctr,
                EvPM = evpm
            };

            return Page();
        }

    }
}
