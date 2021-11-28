using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestLab.Contracts
{
    public class SubmitOrder
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
    }
    public class OrderAccepted
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string CustomerId { get; set; }
    }
    public class OrderRejected
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string CustomerId { get; set; }
        public string Reason { get; set; }
    }
}