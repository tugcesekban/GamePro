using GamePro.Abstracts;
using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Concreate
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + "named game is added to the DB");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + "named game is deleted to from the DB");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + "named game is updated on the DB");
        }
    }
}
