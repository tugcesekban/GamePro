using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Abstracts
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
