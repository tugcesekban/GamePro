using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Abstracts
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game game);
        void CampaignSale(Gamer gamer, Game game, Campaign campaign);
    }
}
