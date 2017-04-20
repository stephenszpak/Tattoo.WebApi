using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TattooStyles.Api.Controllers;
using TattooStyles.Api.Models;

namespace TattooStyles.Api.DAL
{
    public class TattooGetter : ITattooGetter
    {
        public AmericanTrad GetAmericanTradTattoosById(int id)
        {
            if (id == 0) return null;

            return new AmericanTrad
            {
                Artist = "Sting",
                Location = "New York",
                ShopName = "The TurtleDuck"
            };
        }

        public Japanese GetJapaneseTattoosById(int id)
        {
            if (id == 0) return null;

            return new Japanese
            {
                Artist = "Billy",
                Location = "New York",
                ShopName = "The TurtleDuck"
            };
        }
    }
}