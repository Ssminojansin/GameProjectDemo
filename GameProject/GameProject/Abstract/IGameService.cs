using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    internal interface IGameService
    {
        void GameAdd(Game game);
        void GameDelete(Game game);
        void GameUpdate(Game game);

    }
}
