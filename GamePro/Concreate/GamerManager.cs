using GamePro.Abstracts;
using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Concreate
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService gamerCheckService;
        public GamerManager(IGamerCheckService _gamerCheckService)
        {
            gamerCheckService = _gamerCheckService;
        }
        public override void Add(Gamer gamer)
        {
            if (gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
