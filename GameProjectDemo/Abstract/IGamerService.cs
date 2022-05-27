using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameProjectDemo.Entities;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
