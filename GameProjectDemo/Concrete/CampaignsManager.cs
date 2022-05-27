using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class CampaignsManager : ICampaignsService
    {
        public void Add(Campaigns campaigns)
        {
            Console.WriteLine("Campaign added " + campaigns.CampaignName);
        }

        public void Delete(Campaigns campaigns)
        {
            Console.WriteLine("Campaign deleted " + campaigns.CampaignName);
        }

        public void Update(Campaigns campaigns)
        {
            Console.WriteLine("Campaign updated" + campaigns.CampaignName);
        }
    }
}
