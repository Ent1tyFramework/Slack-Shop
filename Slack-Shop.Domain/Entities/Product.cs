using Slack_Shop.Domain.Enums;
using Slack_Shop.Domain.Interfaces;
using System;

namespace Slack_Shop.Domain.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProductType Type { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public DateTime PublishTime { get; set; }
    }
}
