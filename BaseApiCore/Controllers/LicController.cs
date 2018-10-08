using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApiCore.Business;
using BaseApiCore.Data;
using BaseApiCore.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaseApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicController : ControllerBase
    {
       // private readonly IUnitOfWork _unitOfWork;
        private readonly IDomain _domain;
        private readonly LicDBContext _licDBContext; 
        public LicController(IDomain domain, DbContextOptions<LicDBContext> dbContextOptions)
        {
            //_unitOfWork = unitOfWork;
            _domain = domain;
            _licDBContext = new LicDBContext(dbContextOptions);
        }
        [Route("States")]
        public IActionResult GetStates()
        {
            var res = _domain.GetStates();
            return new ObjectResult(res);
        }
    }
}