using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class SaleManager : ISaleService
    {
        public void DiscountSale(Games games, Gamer gamer, Campaigns campaigns)
        {
            double newPrice = games.GamePrice - (games.GamePrice * campaigns.Discount);
            Console.WriteLine(games.GameName + " Adlı oyun " + gamer.UserName + " Adlı oyuncuya " + campaigns.CampaignName + " kampayanyası uygulanmıştır." + " Yeni Fiyat: " + newPrice);

        }

        public void Sale(Games games, Gamer gamer)
        {
            Console.WriteLine(games.GameName + " Adlı oyun " + gamer.UserName + " Adlı oyuncuya satılmıştır" + "  Fiyat: " + games.GamePrice);
        }
    }
}
