using GameGamerCampaignOrder.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGamerCampaignOrder.Concrete
{
    class GamerManager:IGamerService
    {

        public void Add(Gamer gamer)
        {
            Console.WriteLine("adlı oyuncu için");
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
