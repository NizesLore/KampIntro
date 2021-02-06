using GameGamerCampaignOrder.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGamerCampaignOrder.Concrete
{
    class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanyası dahilinde");
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    



}
