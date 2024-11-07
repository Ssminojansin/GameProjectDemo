using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrate
{
    internal class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game , Campaign campaign)
        {
            //Console.WriteLine("Oyuncu : " + gamer.FirstName + game.GameName + "Adlı Oyunu : " + "Kampanyalı satışı : " + campaign.CampaignName + " % " + campaign.Discount + "iskonto ile satılmıştır." );


            Console.WriteLine(game.GameName + " isimli oyun " + gamer.FirstName + " tarafından %" +
                campaign.Discount + " indirimle satın alındı ve " +
                (game.GamePrice - (game.GamePrice * (campaign.Discount / 100))) + " TL ödendi.");

        }

       
        
    }
}
