using Microsoft.AspNetCore.Mvc;
using PatientReferralApi.Domain;
using PatientReferralApi.Services;

namespace PatientReferralApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;
        private readonly PatientService PatientService;

        public PatientController(ILogger<PatientController> logger)
        {
            _logger = logger;
            PatientService = new PatientService();
        }

        [HttpGet]
        public IEnumerable<Patient> GetAll()
        {
            _logger.LogDebug("Getting all patients");
            return PatientService.GetAll();
        }
    }
}
