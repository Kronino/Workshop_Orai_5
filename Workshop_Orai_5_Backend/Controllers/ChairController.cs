using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Workshop_Orai_5_Backend.Services;

namespace Workshop_Orai_5_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChairController : ControllerBase
    {
        private readonly ILogger<ChairController> _logger;
        private readonly IHubContext<SignalRHub> _hub;

        public ChairController(ILogger<ChairController> logger, IHubContext<SignalRHub> hub)
        {
            _logger = logger;
            _hub = hub;
        }

        [HttpGet(Name = "GetChair")]
        public IEnumerable<Chair> ReadAll()
        {
            return ChairRepo.chairs;
        }

        [HttpPut]
        public void Update([FromBody] Chair value)
        {
            var chair = ChairRepo.chairs.Where(chair => chair.ChairNumber == value.ChairNumber).FirstOrDefault();
            chair.ReserverName = value.ReserverName;
            chair.IsReserved = value.IsReserved;

            _hub.Clients.All.SendAsync("ChairReserved", value);
        }
    }
}
