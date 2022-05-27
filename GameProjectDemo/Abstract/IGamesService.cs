using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    interface IGamesService
    {
        void Add(Games games);
        void Update(Games games);
        void Delete(Games games);
    }
}
