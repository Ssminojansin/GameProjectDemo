using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrate
{
    internal class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi  :  " + campaign.CampaignName);
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi  :  " + campaign.CampaignName);
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi  :  " + campaign.CampaignName);
        }
    }
}
