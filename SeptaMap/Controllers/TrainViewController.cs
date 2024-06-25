using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeptaMap.Infrastructure.External.Services;

namespace SeptaMap.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainController : ControllerBase
    {
        private readonly TrainViewService _trainViewService;

        public TrainController(TrainViewService trainViewService)
        {
            _trainViewService = trainViewService;
        }

        [HttpGet("trainview")]
        public async Task<IActionResult> GetTrainView()
        {
            var trainView = await _trainViewService.GetTrainViewAsync();
            return Ok(trainView);
        }
    }
}
