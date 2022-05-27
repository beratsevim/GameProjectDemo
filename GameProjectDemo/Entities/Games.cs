using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    class Games : IEntitity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public double GamePrice { get; set; }
    }
}
