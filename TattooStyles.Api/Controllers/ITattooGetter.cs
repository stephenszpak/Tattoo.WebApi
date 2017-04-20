using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooStyles.Api.Models;

namespace TattooStyles.Api.Controllers
{
    public interface ITattooGetter
    {
        AmericanTrad GetAmericanTradTattoosById(int id);
        Japanese GetJapaneseTattoosById(int id);
    }
}
