using GameProjectDemo.Entities;
using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Adapters;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                DateOfBirth = new DateTime(2001,02,12),
                FirstName = "Berat",
                LastName = "Sevim",
                NationalityId = 000000000000,
                UserName = "Beratsvm",
            };
            Gamer gamer2 = new Gamer()
            {    
                Id = 2,
                DateOfBirth = new DateTime(2000, 10, 24),
                FirstName = "Baran",
                LastName = "Tetik",
                NationalityId = 00000000000,
                UserName = "Triggerbaran",
            };

            Games game1 = new Games() { Id = 1, GameName = "GTA5", GameCategory = "Real Life", GamePrice = 250 };
            Games game2 = new Games() { Id = 2, GameName = "CsGo", GameCategory = "Video Game",GamePrice = 100 };

            Campaigns campaign1 = new Campaigns() {CampaignName = "New Year",Discount = 0.10, Id = 1};
            Campaigns campaign2 = new Campaigns() {CampaignName = "Special discount for new customer", Discount = 0.20, Id = 2 };

            SaleManager saleManager = new SaleManager();
            saleManager.DiscountSale(game2, gamer1, campaign2);
            Console.WriteLine("-----------------------------------------------");
            saleManager.Sale(game1, gamer2);
            Console.WriteLine("-----------------------------------------------");

            MernisServiceAdapter CheckManager = new MernisServiceAdapter();
            if (CheckManager.CheckIfRealGamer(gamer1))
            {
                Console.WriteLine(gamer1.UserName + " Kullanıcı Doğrulandı");
            }
            else
            {
                Console.WriteLine(gamer1.UserName + " Kullanıcı Doğrulanmadı");
            }
            Console.WriteLine("-----------------------------------------------");

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            if(CheckManager.CheckIfRealGamer(gamer2))
            {
                Console.WriteLine(gamer2.UserName + " Kullanıcı Doğrulandı");
            }
            else
            {
                Console.WriteLine(gamer2.UserName + " Kullanıcı Doğrulanmadı");
            }
            Console.WriteLine("-----------------------------------------------");
           

            CampaignsManager campaignManager = new CampaignsManager();
            campaignManager.Delete(campaign2);
            Console.WriteLine("-----------------------------------------------");
            Console.ReadLine();
        }
    }
}
