using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrate
{
    internal class GamerManager : IGamerService
    {
        IGamerValidationService _validator;
        public GamerManager(IGamerValidationService validator)
        {
            _validator = validator;
        }

        public void GamerAdd(Gamer gamer)
        {
            if (_validator.Validate(gamer))
            {
                Console.WriteLine("Oyuncu Kayıt Edildi  :  " + gamer.FirstName);

            }
            else
            {
                Console.WriteLine("Hatalı Kayıt");
            }

        }

        public void GamerDelete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi  :  " + gamer.FirstName);
        }

        public void GamerUpdate(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi  :  "  + gamer.FirstName);
        }
    }
}
