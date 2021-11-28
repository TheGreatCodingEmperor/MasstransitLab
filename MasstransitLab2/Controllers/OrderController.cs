using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using TestLab.Contracts;
using TestLab.Components.Consumers;

namespace MasstransitLab2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController:ControllerBase
    {
        public OrderController(
            IRequestClient<SubmitOrder> submitOrderRequestClient)
        {
            _submitOrderRequestClient = submitOrderRequestClient;
        }

        readonly IRequestClient<SubmitOrder> _submitOrderRequestClient;

        [HttpPost]
        public async Task<IActionResult> SubmitOrder([FromQuery] SubmitOrder command)
        {
            var response = await _submitOrderRequestClient.GetResponse<OrderAccepted>(command);
            return Ok(response.Message);
        }
    }
}
