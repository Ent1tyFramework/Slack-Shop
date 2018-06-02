using Slack_Shop.Data.Enums;
using System;

namespace Slack_Shop.Data
{
    internal class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProductType Type { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public DateTime PublishTime { get; set; }
    }
}
