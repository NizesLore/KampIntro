using GameDemo.Entities;
using GameGamerCampaignOrder.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGamerCampaignOrder.Concrete
{
    class GameManager:IGameService
    {

        public void Add(Game game)
        {
            Console.WriteLine("oyunun alarak");
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
