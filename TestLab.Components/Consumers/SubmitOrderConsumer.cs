using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MassTransit;
using TestLab.Contracts;
using System.Threading.Tasks;

namespace TestLab.Components.Consumers
{
    public class SubmitOrderConsumer : IConsumer<SubmitOrder>
    {
        public async Task Consume(ConsumeContext<SubmitOrder> context) => await context.RespondAsync<OrderAccepted>(
                new OrderAccepted()
                {
                    Id = context.Message.Id,
                    Timestamp = InVar.Timestamp,
                    CustomerId = context.Message.CustomerId
                });
    }
}