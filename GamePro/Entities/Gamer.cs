using GamePro.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Entities
{
   public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }
    }
}
