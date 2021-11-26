using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connect.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Connect.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
         
    }
}