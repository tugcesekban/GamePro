using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Abstracts
{
   public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "is added to the Db");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "is deleted from the Db");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "is updated on the Db");
        }
    }
}
