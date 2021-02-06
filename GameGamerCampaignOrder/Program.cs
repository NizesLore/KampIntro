using GameDemo.Entities;
using GameGamerCampaignOrder.Concrete;
using System;

namespace GameGamerCampaignOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Nizes";

            Gamer gamer2 = new Gamer();
            gamer1.Id = 2;
            gamer1.FirstName = "Lore";


            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { Id = 1, Name = "Saklambaç", Price = 50 });
            gameManager.Add(new Game { Id = 2, Name = "Köşe kapmaca", Price = 60 });
            gameManager.Add(new Game { Id = 3, Name = "Mendil kapmaca", Price = 70 });

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(new Gamer {Id=1,FirstName="Nizes" });
            gamerManager.Add(new Gamer { Id = 2, FirstName = "Lore" });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 1 , Name="1 alana % 10"});
            campaignManager.Add(new Campaign { Id = 2, Name = "2 alana % 20" });
            campaignManager.Add(new Campaign { Id = 3, Name = "3 alana % 30" });


            OrderManager orderManager = new OrderManager();
            orderManager.Add(new Order { Id=1, CampaignName=1});
            orderManager.Add(new Order { Id = 2, CampaignName = 2 });
            orderManager.Add(new Order { Id = 3, CampaignName = 3 });


            Console.WriteLine();
          
        }
    }
}
