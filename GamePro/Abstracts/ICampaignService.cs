using GamePro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Abstracts
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
