using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppTest.Controllers
{
    [ApiController]
    public class NegotiationController : ControllerBase
    {
        [HttpGet]
        [Route("about")]
        //GET help
        public string Get()
        {
            return "Send Post with an Aidbox Operation resource in the body";
        }

        // POST negotiate-mdtb-link
        [Route("negotiate-mdtb-link")]
        [HttpPost]
        public string Post(object aidboxRequest)
        {
            return "ok";
        }
    }
}
