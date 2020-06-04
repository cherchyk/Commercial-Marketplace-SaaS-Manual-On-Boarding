﻿using System;
using Microsoft.Marketplace.Models;
using Newtonsoft.Json;

namespace Dashboard.Webhook
{
    public class WebhookPayload
    {
        public WebhookAction Action { get; set; }

        public Guid ActivityId { get; set; }

        public string OfferId { get; set; }

        // Operation Id is presented as Id property on the json payload
        [JsonProperty(PropertyName = "Id")] public Guid OperationId { get; set; }

        public string PlanId { get; set; }
        public string PublisherId { get; set; }
        public int Quantity { get; set; }
        public OperationStatusEnum Status { get; set; }
        public Guid SubscriptionId { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}