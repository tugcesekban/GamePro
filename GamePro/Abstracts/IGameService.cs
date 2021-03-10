using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Abstracts
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
