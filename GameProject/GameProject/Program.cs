using GameProject.Abstract;
using GameProject.Concrate;
using GameProject.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
      
        Game game = new Game();
        game.GameId = 1;
        game.GameName = "Gta V";
        game.GamePrice = 1000;

        
        Campaign campaign = new Campaign();
        campaign.CampaignId = 1;
        campaign.CampaignName = " Summer % 25 Discount";
        campaign.Discount = 25;


        Gamer gamer = new Gamer();
        gamer.Id = 1;
        gamer.FirstName = "Coskun";
        gamer.LastName = "Temenni";
        gamer.IdentityNumber = 123456789;
        gamer.DateOfBirth = 1995;

        GameManager gameManager = new GameManager();
        gameManager.GameAdd(game);

        Console.WriteLine("++++++++++++++++++++++++++");

        GamerManager gamerManager = new GamerManager(new GamerValidationManager());
        gamerManager.GamerAdd(gamer);

        Console.WriteLine("++++++++++++++++++++++++++");

        CampaignManager campaignManager = new CampaignManager();
        campaignManager.CampaignAdd(campaign);

        Console.WriteLine("++++++++++++++++++++++++++");

        SaleManager saleManager = new SaleManager();
        saleManager.Sale(gamer , game , campaign);



      

        

        



    }

}