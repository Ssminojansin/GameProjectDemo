using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrate
{
    internal class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth == 1994 && gamer.FirstName == "Coskun" && gamer.LastName == "Temenni" && gamer.IdentityNumber == 123456789)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
