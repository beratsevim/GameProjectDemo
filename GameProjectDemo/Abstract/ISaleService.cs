using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    interface ISaleService
    {
        void DiscountSale(Games game, Gamer gamer, Campaigns campaigns);
        void Sale(Games games, Gamer gamer);
    }
}
