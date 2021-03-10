using GamePro.Adapters;
using GamePro.Concreate;
using GamePro.Entities;
using System;

namespace GamePro
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer = new Gamer {Id=1, FirstName="Berna", Surname="Akın", NationalId="1111111111111", DateOfBirth=new DateTime(1991,1,1) };

            gamerManager.Add(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);

            Game game = new Game { Id=2, Name="GoodGame", Description="It's so awesome", Price=200};
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            Campaign campaign = new Campaign {Id=3, Name="Big Sale", Discount=10 };
            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);
        }
    }
}
