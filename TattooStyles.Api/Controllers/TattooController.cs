using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TattooStyles.Api.DAL;

namespace TattooStyles.Api.Controllers
{
    public class TattooController : ApiController
    {
            readonly ITattooGetter _getter;

            public TattooController()
            {
            _getter = new TattooGetter();
            }

            public TattooController(ITattooGetter getter)
            {
                _getter = getter;
            }

            [HttpGet]
            [Route("api/AmerTradTattoo/{id}")]
            public HttpResponseMessage GetAmericanTradTattoo(int id)
            {
                var tats = _getter.GetAmericanTradTattoosById(id);

                if (tats == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        $"The Tattoo with an id of {id} does not exist");
                }

                return Request.CreateResponse(HttpStatusCode.OK, tats);
            }

        [HttpGet]
        [Route("api/JapaneseTattoo/{id}")]
        public HttpResponseMessage GetJapaneseTattooById(int id)
        {
            var tats = _getter.GetJapaneseTattoosById(id);

            if (tats == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The Tattoo with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, tats);
        }

    }
}
