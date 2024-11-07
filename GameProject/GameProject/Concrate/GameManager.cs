using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrate
{
    internal class GameManager : IGameService
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine("Oyun Eklendi  :  " + game.GameName);
        }

        public void GameDelete(Game game)
        {
            Console.WriteLine("Oyun Silindi  :  " + game.GameName);
        }

        public void GameUpdate(Game game)
        {
            Console.WriteLine("Oyun Güncellendi  :  " + game.GameName);
        }
    }
}
