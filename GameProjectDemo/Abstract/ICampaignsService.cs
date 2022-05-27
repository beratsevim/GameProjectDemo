using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameProjectDemo.Entities;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    interface ICampaignsService
    {
        void Add(Campaigns campaigns);
        void Update(Campaigns campaigns);
        void Delete(Campaigns campaigns);
    }
}
