using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
     class GamesManager : IGamesService
    {
        public void Add(Games games)
        {
            Console.WriteLine("New game added " + games.GameName);
        }

        public void Delete(Games games)
        {
            Console.WriteLine("Game deleted " + games.GameName);
        }

        public void Update(Games games)
        {
            Console.WriteLine("Game updated " + games.GameName);
        }
    }
}
