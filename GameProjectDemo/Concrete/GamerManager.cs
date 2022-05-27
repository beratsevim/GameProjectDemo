using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameProjectDemo.Abstract;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _checkService;
        public GamerManager(IGamerCheckService checkService)
        {
            _checkService = checkService;
        }      
        public void Add(Gamer gamer)
        {
            if (_checkService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine("Gamer Added " + gamer.UserName);
            }
            else
            {
                Console.WriteLine("Gamer NOT Added " + gamer.UserName);
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted " + gamer.UserName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated " + gamer.UserName);
        }
    }
}
