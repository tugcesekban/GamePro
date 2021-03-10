using GamePro.Abstracts;
using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Concreate
{
    class SalesManager : ISaleService
    {
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            int discount = game.Price - ((game.Price * campaign.Discount) / 100);
            Console.WriteLine(game.Name + "named game" + "is sold" + gamer.FirstName + " to named gamer %" + campaign.Discount + "with this discount"
             );
        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(game.Name + " named game" + "is sold " + gamer.FirstName);
        }
    }
}