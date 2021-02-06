using GameDemo.Entities;
using GameGamerCampaignOrder.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGamerCampaignOrder.Concrete
{
    class OrderManager:IOrderService
    {

        public void Add(Order order)
        {
            Console.WriteLine("siparişi oluşturuldu."); 
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
