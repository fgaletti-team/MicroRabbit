using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{    // create 41
    [Route("api/[controller]")]
    [ApiController]
    public class BakingController : ControllerBase
    {
        private readonly IAccountService _accontService;
        // GET api/banking

        public BakingController (IAccountService accountService)
        {
            _accontService = accountService;
        }

        // 41 
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accontService.GetAccounts());
        }

        // 44 
        [HttpPost]
        public ActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accontService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }


    }
}
