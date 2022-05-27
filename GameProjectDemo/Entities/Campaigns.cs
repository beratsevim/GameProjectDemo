using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    class Campaigns : IEntitity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double Discount{ get; set; }
    }
}
