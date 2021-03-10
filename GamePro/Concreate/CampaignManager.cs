using GamePro.Abstracts;
using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Concreate
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "named campaign is added to the DB");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "named campaign is deleted from the DB");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "named campaign is updated on the DB");
        }
    }
}
