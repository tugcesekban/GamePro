using GamePro.Abstracts;
using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Concreate
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
