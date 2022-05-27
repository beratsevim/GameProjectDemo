using System;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Entities
{
    public class Gamer : IEntitity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }

    }
}
