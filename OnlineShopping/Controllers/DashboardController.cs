using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Shopping.ApplicationService;

namespace OnlineShopping.Controllers
{
    [Route("api")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardApplicationService _dashboardApplicationService;
        public DashboardController(IDashboardApplicationService dashboardApplicationService)
        {
            _dashboardApplicationService = dashboardApplicationService;
        }
        [HttpGet("kpi")]
        public async Task<IActionResult> Kpi()
        {
            var result =  await _dashboardApplicationService.Kpi();
            return Ok(result);
        }
    }
}
